package org.ldk.batteries;

import javax.annotation.Nullable;

import org.ldk.enums.Network;
import org.ldk.structs.*;

import java.io.IOException;
import java.util.HashSet;


/**
 * A simple utility class which assists in constructing a fresh or deserializing from disk a ChannelManager and one or
 * more ChannelMonitors.
 *
 * Also constructs a PeerManager and spawns a background thread to monitor for and notify you of relevant Events.
 *
 * Note that you must ensure you hold a reference to any constructed ChannelManagerConstructor objects to ensure you
 * continue to receive events generated by the background thread which will be stopped if this object is garbage
 * collected.
 */
public class ChannelManagerConstructor {
    /**
     * An Exception that indicates the serialized data is invalid and has been corrupted on disk. You should attempt to
     * restore from a backup if there is one which is known to be current. Otherwise, funds may have been lost.
     */
    public static class InvalidSerializedDataException extends Exception {
        InvalidSerializedDataException(String reason) {
            super(reason);
        }
    }

    /**
     * The ChannelManager either deserialized or newly-constructed.
     */
    public final ChannelManager channel_manager;
    /**
     * The latest block has the channel manager saw. If this is non-null it is a 32-byte block hash.
     * You should sync the blockchain starting with the block that builds on this block.
     */
    public final byte[] channel_manager_latest_block_hash;
    /**
     * A list of ChannelMonitors and the last block they each saw. You should sync the blockchain on each individually
     * starting with the block that builds on the hash given.
     * After doing so (and syncing the blockchain on the channel manager as well), you should call chain_sync_completed()
     * and then continue to normal application operation.
     */
    public final TwoTuple_ThirtyTwoBytesChannelMonitorZ[] channel_monitors;
    /**
     * A PeerManager which is constructed to pass messages and handle connections to peers.
     *
     * This is `null` until `chain_sync_completed` is called.
     */
    public PeerManager peer_manager = null;
    /**
     * A NioPeerHandler which manages a background thread to handle socket events and pass them to the peer_manager.
	 *
	 * This is `null` until `chain_sync_completed` is called.
     */
    public NioPeerHandler nio_peer_handler = null;

    private final ChainMonitor chain_monitor;

    /**
     * The `NetworkGraph` deserialized from the byte given to the constructor when deserializing or the `NetworkGraph`
     * given explicitly to the new-object constructor.
     */
    public final NetworkGraph net_graph;

    /**
     * A mutex holding the `ProbabilisticScorer` which was loaded on startup.
     */
    public final MultiThreadedLockableScore scorer;
    /**
     * We wrap the scorer in a MultiThreadedLockableScore which ultimately gates access to the scorer, however sometimes
     * we want to expose underlying details of the scorer itself. Thus, we expose a safe version that takes the lock
     * then returns a reference to this scorer.
     */
    private final ProbabilisticScorer prob_scorer;
    private final Logger logger;
    private final EntropySource entropy_source;
    private final NodeSigner node_signer;

    /**
     * Exposes the `ProbabilisticScorer` wrapped inside a lock. Don't forget to `close` this lock when you're done with
     * it so normal scoring operation can continue.
     */
    public class ScorerWrapper implements AutoCloseable {
        private final ScoreUpdate lock;
        public final ProbabilisticScorer prob_scorer;
        private ScorerWrapper(ScoreUpdate lock, ProbabilisticScorer prob_scorer) {
            this.lock = lock; this.prob_scorer = prob_scorer;
        }
        @Override public void close() throws Exception {
            lock.destroy();
        }
    }
    /**
     * Gets the `ProbabilisticScorer` which backs the public lockable `scorer`. Don't forget to `close` the lock when
     * you're done with it.
     */
    public ScorerWrapper get_locked_scorer() {
        return new ScorerWrapper(this.scorer.as_LockableScore().write_lock(), this.prob_scorer);
    }

    /**
     * A simple interface to provide routes to LDK.
     */
    public interface RouterWrapper {
        /**
         * Gets a route for the given payment.
         *
         * @param payment_hash is non-null for this-node-originated payments, however in the future trampoline or other
         *                     HTLC re-routing may cause it to be null as we find routes for payments which we did not
         *                     originate.
         * @param payment_id is non-null for this-node-originated payments, however in the future trampoline or other
         *                   HTLC re-routing may cause it to be null as we find routes for payments which we did not
         *                   originate.
         * @param default_router Provides a router which uses the LDK route-finder and a ProbabilisticScorer using the
         *                       provided ProbabilisticScoringParameters. You may use this to fetch a "default" route,
         *                       modifying or storing it as you wish before returning the route to LDK.
         */
        Result_RouteLightningErrorZ find_route(byte[] payer_node_id, RouteParameters route_params, ChannelDetails[] first_hops,
            InFlightHtlcs inflight_htlcs, @Nullable byte[] payment_hash, @Nullable byte[] payment_id, DefaultRouter default_router);
    }

    /**
     * Deserializes a channel manager and a set of channel monitors from the given serialized copies and interface implementations
     *
     * @param filter If provided, the outputs which were previously registered to be monitored for will be loaded into the filter.
     *               Note that if the provided Watch is a ChainWatch and has an associated filter, the previously registered
     *               outputs will be loaded when chain_sync_completed is called.
     * @param router_wrapper If provided, routes will be fetched by calling the given router rather than an LDK `DefaultRouter`.
     */
    public ChannelManagerConstructor(byte[] channel_manager_serialized, byte[][] channel_monitors_serialized, UserConfig config,
                                     EntropySource entropy_source, NodeSigner node_signer, SignerProvider signer_provider,
                                     FeeEstimator fee_estimator, ChainMonitor chain_monitor,
                                     @Nullable Filter filter, byte[] net_graph_serialized,
                                     ProbabilisticScoringDecayParameters scoring_decay_params,
                                     ProbabilisticScoringFeeParameters scoring_fee_params,
                                     byte[] probabilistic_scorer_bytes, @Nullable RouterWrapper router_wrapper,
                                     BroadcasterInterface tx_broadcaster, Logger logger) throws InvalidSerializedDataException {
        this.entropy_source = entropy_source;
        this.node_signer = node_signer;

        Result_NetworkGraphDecodeErrorZ graph_res = NetworkGraph.read(net_graph_serialized, logger);
        if (!graph_res.is_ok()) {
            throw new InvalidSerializedDataException("Serialized Network Graph was corrupt");
        }
        this.net_graph = ((Result_NetworkGraphDecodeErrorZ.Result_NetworkGraphDecodeErrorZ_OK)graph_res).res;
        assert(scoring_decay_params != null);
        assert(probabilistic_scorer_bytes != null);
        Result_ProbabilisticScorerDecodeErrorZ scorer_res = ProbabilisticScorer.read(probabilistic_scorer_bytes, scoring_decay_params, net_graph, logger);
        if (!scorer_res.is_ok()) {
            throw new InvalidSerializedDataException("Serialized ProbabilisticScorer was corrupt");
        }
        this.prob_scorer = ((Result_ProbabilisticScorerDecodeErrorZ.Result_ProbabilisticScorerDecodeErrorZ_OK)scorer_res).res;
        this.scorer = MultiThreadedLockableScore.of(this.prob_scorer.as_Score());

        assert(scoring_fee_params != null);
        DefaultRouter default_router = DefaultRouter.of(this.net_graph, logger, entropy_source.get_secure_random_bytes(), scorer.as_LockableScore(), scoring_fee_params);
        Router router;
        if (router_wrapper != null) {
            router = Router.new_impl(new Router.RouterInterface() {
                @Override public Result_RouteLightningErrorZ find_route(byte[] payer, RouteParameters route_params, ChannelDetails[] first_hops, InFlightHtlcs inflight_htlcs) {
                    return router_wrapper.find_route(payer, route_params, first_hops, inflight_htlcs, null, null, default_router);
                }
                @Override public Result_RouteLightningErrorZ find_route_with_id(byte[] payer, RouteParameters route_params, ChannelDetails[] first_hops, InFlightHtlcs inflight_htlcs, byte[] payment_hash, byte[] payment_id) {
                    return router_wrapper.find_route(payer, route_params, first_hops, inflight_htlcs, payment_hash, payment_id, default_router);
                }
            });
        } else {
            router = default_router.as_Router();
        }

        final ChannelMonitor[] monitors = new ChannelMonitor[channel_monitors_serialized.length];
        this.channel_monitors = new TwoTuple_ThirtyTwoBytesChannelMonitorZ[monitors.length];
        HashSet<OutPoint> monitor_funding_set = new HashSet();
        for (int i = 0; i < monitors.length; i++) {
            Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ res = UtilMethods.C2Tuple_ThirtyTwoBytesChannelMonitorZ_read(channel_monitors_serialized[i], entropy_source, signer_provider);
            if (res instanceof Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_Err) {
                throw new InvalidSerializedDataException("Serialized ChannelMonitor was corrupt");
            }
            byte[] block_hash = ((Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_OK)res).res.get_a();
            monitors[i] = ((Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ_OK) res).res.get_b();
            this.channel_monitors[i] = TwoTuple_ThirtyTwoBytesChannelMonitorZ.of(block_hash, monitors[i]);
            if (!monitor_funding_set.add(monitors[i].get_funding_txo().get_a()))
                throw new InvalidSerializedDataException("Set of ChannelMonitors contained duplicates (ie the same funding_txo was set on multiple monitors)");
        }
        Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ res =
                UtilMethods.C2Tuple_ThirtyTwoBytesChannelManagerZ_read(channel_manager_serialized, entropy_source,
                        node_signer, signer_provider, fee_estimator, chain_monitor.as_Watch(),
                        tx_broadcaster, router, logger, config, monitors);
        if (!res.is_ok()) {
            throw new InvalidSerializedDataException("Serialized ChannelManager was corrupt");
        }
        this.channel_manager = ((Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ.Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ_OK)res).res.get_b();
        this.channel_manager_latest_block_hash = ((Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ.Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ_OK)res).res.get_a();
        this.chain_monitor = chain_monitor;
        this.logger = logger;
        if (filter != null) {
            for (ChannelMonitor monitor : monitors) {
                monitor.load_outputs_to_watch(filter);
            }
        }
    }

    /**
     * Constructs a channel manager from the given interface implementations
     *
     * @param router_wrapper If provided, routes will be fetched by calling the given router rather than an LDK `DefaultRouter`.
     */
    public ChannelManagerConstructor(Network network, UserConfig config, byte[] current_blockchain_tip_hash, int current_blockchain_tip_height,
                                     EntropySource entropy_source, NodeSigner node_signer, SignerProvider signer_provider,
                                     FeeEstimator fee_estimator, ChainMonitor chain_monitor,
                                     NetworkGraph net_graph, ProbabilisticScoringDecayParameters scoring_decay_params,
                                     ProbabilisticScoringFeeParameters scoring_fee_params,
                                     @Nullable RouterWrapper router_wrapper,
                                     BroadcasterInterface tx_broadcaster, Logger logger) {
        this.entropy_source = entropy_source;
        this.node_signer = node_signer;
        this.net_graph = net_graph;
        assert(scoring_decay_params != null);
        this.prob_scorer = ProbabilisticScorer.of(scoring_decay_params, net_graph, logger);
        this.scorer = MultiThreadedLockableScore.of(this.prob_scorer.as_Score());

        assert(scoring_fee_params != null);
        DefaultRouter default_router = DefaultRouter.of(this.net_graph, logger, entropy_source.get_secure_random_bytes(), scorer.as_LockableScore(), scoring_fee_params);
        Router router;
        if (router_wrapper != null) {
            router = Router.new_impl(new Router.RouterInterface() {
                @Override public Result_RouteLightningErrorZ find_route(byte[] payer, RouteParameters route_params, ChannelDetails[] first_hops, InFlightHtlcs inflight_htlcs) {
                    return router_wrapper.find_route(payer, route_params, first_hops, inflight_htlcs, null, null, default_router);
                }
                @Override public Result_RouteLightningErrorZ find_route_with_id(byte[] payer, RouteParameters route_params, ChannelDetails[] first_hops, InFlightHtlcs inflight_htlcs, byte[] payment_hash, byte[] payment_id) {
                    return router_wrapper.find_route(payer, route_params, first_hops, inflight_htlcs, payment_hash, payment_id, default_router);
                }
            });
        } else {
            router = default_router.as_Router();
        }
        channel_monitors = new TwoTuple_ThirtyTwoBytesChannelMonitorZ[0];
        channel_manager_latest_block_hash = null;
        this.chain_monitor = chain_monitor;
        BestBlock block = BestBlock.of(current_blockchain_tip_hash, current_blockchain_tip_height);
        ChainParameters params = ChainParameters.of(network, block);
        channel_manager = ChannelManager.of(fee_estimator, chain_monitor.as_Watch(), tx_broadcaster, router, logger,
            entropy_source, node_signer, signer_provider, config, params, (int) (System.currentTimeMillis() / 1000));
        this.logger = logger;
    }

    /**
     * Abstract interface which should handle Events and persist the ChannelManager. When you call chain_sync_completed
     * a background thread is started which will automatically call these methods for you when events occur.
     */
    public interface EventHandler {
        void handle_event(Event events);
        void persist_manager(byte[] channel_manager_bytes);
        void persist_network_graph(byte[] network_graph);
        void persist_scorer(byte[] scorer_bytes);
    }

    BackgroundProcessor background_processor = null;

    /**
     * Utility which adds all of the deserialized ChannelMonitors to the chain watch so that further updates from the
     * ChannelManager are processed as normal.
     *
     * This also spawns a background thread which will call the appropriate methods on the provided
     * EventHandler as required.
     *
     * @param use_p2p_graph_sync determines if we will sync the network graph from peers over the standard (but
     *                           inefficient) lightning P2P protocol. Note that doing so currently requires trusting
     *                           peers as no DoS mechanism is enforced to ensure we don't accept bogus gossip.
     *                           Alternatively, you may sync the net_graph exposed in this object via Rapid Gossip Sync.
     */
    public void chain_sync_completed(EventHandler event_handler, boolean use_p2p_graph_sync) {
        if (background_processor != null) { return; }
        for (TwoTuple_ThirtyTwoBytesChannelMonitorZ monitor: channel_monitors) {
            this.chain_monitor.as_Watch().watch_channel(monitor.get_b().get_funding_txo().get_a(), monitor.get_b());
        }
        org.ldk.structs.EventHandler ldk_handler = org.ldk.structs.EventHandler.new_impl(event_handler::handle_event);

        final IgnoringMessageHandler ignoring_handler = IgnoringMessageHandler.of();
        P2PGossipSync graph_msg_handler = P2PGossipSync.of(net_graph, Option_UtxoLookupZ.none(), logger);
        RoutingMessageHandler routing_msg_handler;
        if (use_p2p_graph_sync)
            routing_msg_handler = graph_msg_handler.as_RoutingMessageHandler();
        else
            routing_msg_handler = ignoring_handler.as_RoutingMessageHandler();
        this.peer_manager = PeerManager.of(channel_manager.as_ChannelMessageHandler(),
                routing_msg_handler, ignoring_handler.as_OnionMessageHandler(),
                ignoring_handler.as_CustomMessageHandler(), (int)(System.currentTimeMillis() / 1000),
                this.entropy_source.get_secure_random_bytes(), logger, this.node_signer);

        try {
            this.nio_peer_handler = new NioPeerHandler(peer_manager);
        } catch (IOException e) {
            throw new IllegalStateException("We should never fail to construct nio objects unless we're on a platform that cannot run LDK.");
        }

        GossipSync gossip_sync;
        if (use_p2p_graph_sync)
            gossip_sync = GossipSync.p2_p(graph_msg_handler);
        else
            gossip_sync = GossipSync.none();

        Option_WriteableScoreZ writeable_score = Option_WriteableScoreZ.some(scorer.as_WriteableScore());

        background_processor = BackgroundProcessor.start(Persister.new_impl(new Persister.PersisterInterface() {
            @Override
            public Result_NoneIOErrorZ persist_manager(ChannelManager channel_manager) {
                event_handler.persist_manager(channel_manager.write());
                return Result_NoneIOErrorZ.ok();
            }

            @Override
            public Result_NoneIOErrorZ persist_graph(NetworkGraph network_graph) {
                event_handler.persist_network_graph(network_graph.write());
                return Result_NoneIOErrorZ.ok();
            }

            @Override
            public Result_NoneIOErrorZ persist_scorer(WriteableScore scorer) {
                event_handler.persist_scorer(scorer.write());
                return Result_NoneIOErrorZ.ok();
            }
        }), ldk_handler, this.chain_monitor, this.channel_manager, gossip_sync, peer_manager, this.logger, writeable_score);
    }

    /**
     * Interrupt the background thread, stopping the background handling of events.
     */
    public void interrupt() {
        if (this.nio_peer_handler != null)
            this.nio_peer_handler.interrupt();
        this.background_processor.stop();
    }
}
