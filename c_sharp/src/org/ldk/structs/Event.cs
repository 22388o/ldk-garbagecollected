using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An Event which you should probably take some action in response to.
 * 
 * Note that while Writeable and Readable are implemented for Event, you probably shouldn't use
 * them directly as they don't round-trip exactly (for example FundingGenerationReady is never
 * written as it makes no sense to respond to it after reconnecting to peers).
 */
public class Event : CommonBase {
	protected Event(object _dummy, long ptr) : base(ptr) { }
	~Event() {
		if (ptr != 0) { bindings.Event_free(ptr); }
	}

	internal static Event constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKEvent_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Event_FundingGenerationReady(ptr);
			case 1: return new Event_PaymentClaimable(ptr);
			case 2: return new Event_PaymentClaimed(ptr);
			case 3: return new Event_ConnectionNeeded(ptr);
			case 4: return new Event_InvoiceRequestFailed(ptr);
			case 5: return new Event_PaymentSent(ptr);
			case 6: return new Event_PaymentFailed(ptr);
			case 7: return new Event_PaymentPathSuccessful(ptr);
			case 8: return new Event_PaymentPathFailed(ptr);
			case 9: return new Event_ProbeSuccessful(ptr);
			case 10: return new Event_ProbeFailed(ptr);
			case 11: return new Event_PendingHTLCsForwardable(ptr);
			case 12: return new Event_HTLCIntercepted(ptr);
			case 13: return new Event_SpendableOutputs(ptr);
			case 14: return new Event_PaymentForwarded(ptr);
			case 15: return new Event_ChannelPending(ptr);
			case 16: return new Event_ChannelReady(ptr);
			case 17: return new Event_ChannelClosed(ptr);
			case 18: return new Event_DiscardFunding(ptr);
			case 19: return new Event_OpenChannelRequest(ptr);
			case 20: return new Event_HTLCHandlingFailed(ptr);
			case 21: return new Event_BumpTransaction(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Event of type FundingGenerationReady */
	public class Event_FundingGenerationReady : Event {
		/**
		 * The random channel_id we picked which you'll need to pass into
		 * [`ChannelManager::funding_transaction_generated`].
		 * 
		 * [`ChannelManager::funding_transaction_generated`]: crate::ln::channelmanager::ChannelManager::funding_transaction_generated
		 */
		public ChannelId temporary_channel_id;
		/**
		 * The counterparty's node_id, which you'll need to pass back into
		 * [`ChannelManager::funding_transaction_generated`].
		 * 
		 * [`ChannelManager::funding_transaction_generated`]: crate::ln::channelmanager::ChannelManager::funding_transaction_generated
		 */
		public byte[] counterparty_node_id;
		/**
		 * The value, in satoshis, that the output should have.
		 */
		public long channel_value_satoshis;
		/**
		 * The script which should be used in the transaction output.
		 */
		public byte[] output_script;
		/**
		 * The `user_channel_id` value passed in to [`ChannelManager::create_channel`] for outbound
		 * channels, or to [`ChannelManager::accept_inbound_channel`] for inbound channels if
		 * [`UserConfig::manually_accept_inbound_channels`] config flag is set to true. Otherwise
		 * `user_channel_id` will be randomized for an inbound channel.  This may be zero for objects
		 * serialized with LDK versions prior to 0.0.113.
		 * 
		 * [`ChannelManager::create_channel`]: crate::ln::channelmanager::ChannelManager::create_channel
		 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
		 * [`UserConfig::manually_accept_inbound_channels`]: crate::util::config::UserConfig::manually_accept_inbound_channels
		 */
		public UInt128 user_channel_id;
		internal Event_FundingGenerationReady(long ptr) : base(null, ptr) {
			long temporary_channel_id = bindings.LDKEvent_FundingGenerationReady_get_temporary_channel_id(ptr);
			org.ldk.structs.ChannelId temporary_channel_id_hu_conv = null; if (temporary_channel_id < 0 || temporary_channel_id > 4096) { temporary_channel_id_hu_conv = new org.ldk.structs.ChannelId(null, temporary_channel_id); }
			if (temporary_channel_id_hu_conv != null) { temporary_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.temporary_channel_id = temporary_channel_id_hu_conv;
			long counterparty_node_id = bindings.LDKEvent_FundingGenerationReady_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			this.channel_value_satoshis = bindings.LDKEvent_FundingGenerationReady_get_channel_value_satoshis(ptr);
			long output_script = bindings.LDKEvent_FundingGenerationReady_get_output_script(ptr);
			byte[] output_script_conv = InternalUtils.decodeUint8Array(output_script);
			this.output_script = output_script_conv;
			long user_channel_id = bindings.LDKEvent_FundingGenerationReady_get_user_channel_id(ptr);
			org.ldk.util.UInt128 user_channel_id_conv = new org.ldk.util.UInt128(user_channel_id);
			this.user_channel_id = user_channel_id_conv;
		}
	}
	/** A Event of type PaymentClaimable */
	public class Event_PaymentClaimable : Event {
		/**
		 * The node that will receive the payment after it has been claimed.
		 * This is useful to identify payments received via [phantom nodes].
		 * This field will always be filled in when the event was generated by LDK versions
		 * 0.0.113 and above.
		 * 
		 * [phantom nodes]: crate::sign::PhantomKeysManager
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public byte[] receiver_node_id;
		/**
		 * The hash for which the preimage should be handed to the ChannelManager. Note that LDK will
		 * not stop you from registering duplicate payment hashes for inbound payments.
		 */
		public byte[] payment_hash;
		/**
		 * The fields in the onion which were received with each HTLC. Only fields which were
		 * identical in each HTLC involved in the payment will be included here.
		 * 
		 * Payments received on LDK versions prior to 0.0.115 will have this field unset.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public RecipientOnionFields onion_fields;
		/**
		 * The value, in thousandths of a satoshi, that this payment is claimable for. May be greater
		 * than the invoice amount.
		 * 
		 * May be less than the invoice amount if [`ChannelConfig::accept_underpaying_htlcs`] is set
		 * and the previous hop took an extra fee.
		 * 
		 * # Note
		 * If [`ChannelConfig::accept_underpaying_htlcs`] is set and you claim without verifying this
		 * field, you may lose money!
		 * 
		 * [`ChannelConfig::accept_underpaying_htlcs`]: crate::util::config::ChannelConfig::accept_underpaying_htlcs
		 */
		public long amount_msat;
		/**
		 * The value, in thousands of a satoshi, that was skimmed off of this payment as an extra fee
		 * taken by our channel counterparty.
		 * 
		 * Will always be 0 unless [`ChannelConfig::accept_underpaying_htlcs`] is set.
		 * 
		 * [`ChannelConfig::accept_underpaying_htlcs`]: crate::util::config::ChannelConfig::accept_underpaying_htlcs
		 */
		public long counterparty_skimmed_fee_msat;
		/**
		 * Information for claiming this received payment, based on whether the purpose of the
		 * payment is to pay an invoice or to send a spontaneous payment.
		 */
		public PaymentPurpose purpose;
		/**
		 * The `channel_id` indicating over which channel we received the payment.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public ChannelId via_channel_id;
		/**
		 * The `user_channel_id` indicating over which channel we received the payment.
		 */
		public Option_U128Z via_user_channel_id;
		/**
		 * The block height at which this payment will be failed back and will no longer be
		 * eligible for claiming.
		 * 
		 * Prior to this height, a call to [`ChannelManager::claim_funds`] is guaranteed to
		 * succeed, however you should wait for [`Event::PaymentClaimed`] to be sure.
		 * 
		 * [`ChannelManager::claim_funds`]: crate::ln::channelmanager::ChannelManager::claim_funds
		 */
		public Option_u32Z claim_deadline;
		internal Event_PaymentClaimable(long ptr) : base(null, ptr) {
			long receiver_node_id = bindings.LDKEvent_PaymentClaimable_get_receiver_node_id(ptr);
			byte[] receiver_node_id_conv = InternalUtils.decodeUint8Array(receiver_node_id);
			this.receiver_node_id = receiver_node_id_conv;
			long payment_hash = bindings.LDKEvent_PaymentClaimable_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			long onion_fields = bindings.LDKEvent_PaymentClaimable_get_onion_fields(ptr);
			org.ldk.structs.RecipientOnionFields onion_fields_hu_conv = null; if (onion_fields < 0 || onion_fields > 4096) { onion_fields_hu_conv = new org.ldk.structs.RecipientOnionFields(null, onion_fields); }
			if (onion_fields_hu_conv != null) { onion_fields_hu_conv.ptrs_to.AddLast(this); };
			this.onion_fields = onion_fields_hu_conv;
			this.amount_msat = bindings.LDKEvent_PaymentClaimable_get_amount_msat(ptr);
			this.counterparty_skimmed_fee_msat = bindings.LDKEvent_PaymentClaimable_get_counterparty_skimmed_fee_msat(ptr);
			long purpose = bindings.LDKEvent_PaymentClaimable_get_purpose(ptr);
			org.ldk.structs.PaymentPurpose purpose_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(purpose);
			if (purpose_hu_conv != null) { purpose_hu_conv.ptrs_to.AddLast(this); };
			this.purpose = purpose_hu_conv;
			long via_channel_id = bindings.LDKEvent_PaymentClaimable_get_via_channel_id(ptr);
			org.ldk.structs.ChannelId via_channel_id_hu_conv = null; if (via_channel_id < 0 || via_channel_id > 4096) { via_channel_id_hu_conv = new org.ldk.structs.ChannelId(null, via_channel_id); }
			if (via_channel_id_hu_conv != null) { via_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.via_channel_id = via_channel_id_hu_conv;
			long via_user_channel_id = bindings.LDKEvent_PaymentClaimable_get_via_user_channel_id(ptr);
			org.ldk.structs.Option_U128Z via_user_channel_id_hu_conv = org.ldk.structs.Option_U128Z.constr_from_ptr(via_user_channel_id);
			if (via_user_channel_id_hu_conv != null) { via_user_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.via_user_channel_id = via_user_channel_id_hu_conv;
			long claim_deadline = bindings.LDKEvent_PaymentClaimable_get_claim_deadline(ptr);
			org.ldk.structs.Option_u32Z claim_deadline_hu_conv = org.ldk.structs.Option_u32Z.constr_from_ptr(claim_deadline);
			if (claim_deadline_hu_conv != null) { claim_deadline_hu_conv.ptrs_to.AddLast(this); };
			this.claim_deadline = claim_deadline_hu_conv;
		}
	}
	/** A Event of type PaymentClaimed */
	public class Event_PaymentClaimed : Event {
		/**
		 * The node that received the payment.
		 * This is useful to identify payments which were received via [phantom nodes].
		 * This field will always be filled in when the event was generated by LDK versions
		 * 0.0.113 and above.
		 * 
		 * [phantom nodes]: crate::sign::PhantomKeysManager
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public byte[] receiver_node_id;
		/**
		 * The payment hash of the claimed payment. Note that LDK will not stop you from
		 * registering duplicate payment hashes for inbound payments.
		 */
		public byte[] payment_hash;
		/**
		 * The value, in thousandths of a satoshi, that this payment is for. May be greater than the
		 * invoice amount.
		 */
		public long amount_msat;
		/**
		 * The purpose of the claimed payment, i.e. whether the payment was for an invoice or a
		 * spontaneous payment.
		 */
		public PaymentPurpose purpose;
		/**
		 * The HTLCs that comprise the claimed payment. This will be empty for events serialized prior
		 * to LDK version 0.0.117.
		 */
		public ClaimedHTLC[] htlcs;
		/**
		 * The sender-intended sum total of all the MPP parts. This will be `None` for events
		 * serialized prior to LDK version 0.0.117.
		 */
		public Option_u64Z sender_intended_total_msat;
		internal Event_PaymentClaimed(long ptr) : base(null, ptr) {
			long receiver_node_id = bindings.LDKEvent_PaymentClaimed_get_receiver_node_id(ptr);
			byte[] receiver_node_id_conv = InternalUtils.decodeUint8Array(receiver_node_id);
			this.receiver_node_id = receiver_node_id_conv;
			long payment_hash = bindings.LDKEvent_PaymentClaimed_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			this.amount_msat = bindings.LDKEvent_PaymentClaimed_get_amount_msat(ptr);
			long purpose = bindings.LDKEvent_PaymentClaimed_get_purpose(ptr);
			org.ldk.structs.PaymentPurpose purpose_hu_conv = org.ldk.structs.PaymentPurpose.constr_from_ptr(purpose);
			if (purpose_hu_conv != null) { purpose_hu_conv.ptrs_to.AddLast(this); };
			this.purpose = purpose_hu_conv;
			long htlcs = bindings.LDKEvent_PaymentClaimed_get_htlcs(ptr);
			int htlcs_conv_13_len = InternalUtils.getArrayLength(htlcs);
			ClaimedHTLC[] htlcs_conv_13_arr = new ClaimedHTLC[htlcs_conv_13_len];
			for (int n = 0; n < htlcs_conv_13_len; n++) {
				long htlcs_conv_13 = InternalUtils.getU64ArrayElem(htlcs, n);
				org.ldk.structs.ClaimedHTLC htlcs_conv_13_hu_conv = null; if (htlcs_conv_13 < 0 || htlcs_conv_13 > 4096) { htlcs_conv_13_hu_conv = new org.ldk.structs.ClaimedHTLC(null, htlcs_conv_13); }
				if (htlcs_conv_13_hu_conv != null) { htlcs_conv_13_hu_conv.ptrs_to.AddLast(this); };
				htlcs_conv_13_arr[n] = htlcs_conv_13_hu_conv;
			}
			bindings.free_buffer(htlcs);
			this.htlcs = htlcs_conv_13_arr;
			long sender_intended_total_msat = bindings.LDKEvent_PaymentClaimed_get_sender_intended_total_msat(ptr);
			org.ldk.structs.Option_u64Z sender_intended_total_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(sender_intended_total_msat);
			if (sender_intended_total_msat_hu_conv != null) { sender_intended_total_msat_hu_conv.ptrs_to.AddLast(this); };
			this.sender_intended_total_msat = sender_intended_total_msat_hu_conv;
		}
	}
	/** A Event of type ConnectionNeeded */
	public class Event_ConnectionNeeded : Event {
		/**
		 * The node id for the node needing a connection.
		 */
		public byte[] node_id;
		/**
		 * Sockets for connecting to the node.
		 */
		public SocketAddress[] addresses;
		internal Event_ConnectionNeeded(long ptr) : base(null, ptr) {
			long node_id = bindings.LDKEvent_ConnectionNeeded_get_node_id(ptr);
			byte[] node_id_conv = InternalUtils.decodeUint8Array(node_id);
			this.node_id = node_id_conv;
			long addresses = bindings.LDKEvent_ConnectionNeeded_get_addresses(ptr);
			int addresses_conv_15_len = InternalUtils.getArrayLength(addresses);
			SocketAddress[] addresses_conv_15_arr = new SocketAddress[addresses_conv_15_len];
			for (int p = 0; p < addresses_conv_15_len; p++) {
				long addresses_conv_15 = InternalUtils.getU64ArrayElem(addresses, p);
				org.ldk.structs.SocketAddress addresses_conv_15_hu_conv = org.ldk.structs.SocketAddress.constr_from_ptr(addresses_conv_15);
				if (addresses_conv_15_hu_conv != null) { addresses_conv_15_hu_conv.ptrs_to.AddLast(this); };
				addresses_conv_15_arr[p] = addresses_conv_15_hu_conv;
			}
			bindings.free_buffer(addresses);
			this.addresses = addresses_conv_15_arr;
		}
	}
	/** A Event of type InvoiceRequestFailed */
	public class Event_InvoiceRequestFailed : Event {
		/**
		 * The `payment_id` to have been associated with payment for the requested invoice.
		 */
		public byte[] payment_id;
		internal Event_InvoiceRequestFailed(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKEvent_InvoiceRequestFailed_get_payment_id(ptr);
			byte[] payment_id_conv = InternalUtils.decodeUint8Array(payment_id);
			this.payment_id = payment_id_conv;
		}
	}
	/** A Event of type PaymentSent */
	public class Event_PaymentSent : Event {
		/**
		 * The `payment_id` passed to [`ChannelManager::send_payment`].
		 * 
		 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
		 */
		public Option_ThirtyTwoBytesZ payment_id;
		/**
		 * The preimage to the hash given to ChannelManager::send_payment.
		 * Note that this serves as a payment receipt, if you wish to have such a thing, you must
		 * store it somehow!
		 */
		public byte[] payment_preimage;
		/**
		 * The hash that was given to [`ChannelManager::send_payment`].
		 * 
		 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
		 */
		public byte[] payment_hash;
		/**
		 * The total fee which was spent at intermediate hops in this payment, across all paths.
		 * 
		 * Note that, like [`Route::get_total_fees`] this does *not* include any potential
		 * overpayment to the recipient node.
		 * 
		 * If the recipient or an intermediate node misbehaves and gives us free money, this may
		 * overstate the amount paid, though this is unlikely.
		 * 
		 * [`Route::get_total_fees`]: crate::routing::router::Route::get_total_fees
		 */
		public Option_u64Z fee_paid_msat;
		internal Event_PaymentSent(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKEvent_PaymentSent_get_payment_id(ptr);
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_id_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_id);
			if (payment_id_hu_conv != null) { payment_id_hu_conv.ptrs_to.AddLast(this); };
			this.payment_id = payment_id_hu_conv;
			long payment_preimage = bindings.LDKEvent_PaymentSent_get_payment_preimage(ptr);
			byte[] payment_preimage_conv = InternalUtils.decodeUint8Array(payment_preimage);
			this.payment_preimage = payment_preimage_conv;
			long payment_hash = bindings.LDKEvent_PaymentSent_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			long fee_paid_msat = bindings.LDKEvent_PaymentSent_get_fee_paid_msat(ptr);
			org.ldk.structs.Option_u64Z fee_paid_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(fee_paid_msat);
			if (fee_paid_msat_hu_conv != null) { fee_paid_msat_hu_conv.ptrs_to.AddLast(this); };
			this.fee_paid_msat = fee_paid_msat_hu_conv;
		}
	}
	/** A Event of type PaymentFailed */
	public class Event_PaymentFailed : Event {
		/**
		 * The `payment_id` passed to [`ChannelManager::send_payment`].
		 * 
		 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
		 */
		public byte[] payment_id;
		/**
		 * The hash that was given to [`ChannelManager::send_payment`].
		 * 
		 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
		 */
		public byte[] payment_hash;
		/**
		 * The reason the payment failed. This is only `None` for events generated or serialized
		 * by versions prior to 0.0.115.
		 */
		public Option_PaymentFailureReasonZ reason;
		internal Event_PaymentFailed(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKEvent_PaymentFailed_get_payment_id(ptr);
			byte[] payment_id_conv = InternalUtils.decodeUint8Array(payment_id);
			this.payment_id = payment_id_conv;
			long payment_hash = bindings.LDKEvent_PaymentFailed_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			long reason = bindings.LDKEvent_PaymentFailed_get_reason(ptr);
			org.ldk.structs.Option_PaymentFailureReasonZ reason_hu_conv = org.ldk.structs.Option_PaymentFailureReasonZ.constr_from_ptr(reason);
			if (reason_hu_conv != null) { reason_hu_conv.ptrs_to.AddLast(this); };
			this.reason = reason_hu_conv;
		}
	}
	/** A Event of type PaymentPathSuccessful */
	public class Event_PaymentPathSuccessful : Event {
		/**
		 * The `payment_id` passed to [`ChannelManager::send_payment`].
		 * 
		 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
		 */
		public byte[] payment_id;
		/**
		 * The hash that was given to [`ChannelManager::send_payment`].
		 * 
		 * This will be `Some` for all payments which completed on LDK 0.0.104 or later.
		 * 
		 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
		 */
		public Option_ThirtyTwoBytesZ payment_hash;
		/**
		 * The payment path that was successful.
		 * 
		 * May contain a closed channel if the HTLC sent along the path was fulfilled on chain.
		 */
		public Path path;
		internal Event_PaymentPathSuccessful(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKEvent_PaymentPathSuccessful_get_payment_id(ptr);
			byte[] payment_id_conv = InternalUtils.decodeUint8Array(payment_id);
			this.payment_id = payment_id_conv;
			long payment_hash = bindings.LDKEvent_PaymentPathSuccessful_get_payment_hash(ptr);
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_hash_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_hash);
			if (payment_hash_hu_conv != null) { payment_hash_hu_conv.ptrs_to.AddLast(this); };
			this.payment_hash = payment_hash_hu_conv;
			long path = bindings.LDKEvent_PaymentPathSuccessful_get_path(ptr);
			org.ldk.structs.Path path_hu_conv = null; if (path < 0 || path > 4096) { path_hu_conv = new org.ldk.structs.Path(null, path); }
			if (path_hu_conv != null) { path_hu_conv.ptrs_to.AddLast(this); };
			this.path = path_hu_conv;
		}
	}
	/** A Event of type PaymentPathFailed */
	public class Event_PaymentPathFailed : Event {
		/**
		 * The `payment_id` passed to [`ChannelManager::send_payment`].
		 * 
		 * This will be `Some` for all payment paths which failed on LDK 0.0.103 or later.
		 * 
		 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
		 * [`ChannelManager::abandon_payment`]: crate::ln::channelmanager::ChannelManager::abandon_payment
		 */
		public Option_ThirtyTwoBytesZ payment_id;
		/**
		 * The hash that was given to [`ChannelManager::send_payment`].
		 * 
		 * [`ChannelManager::send_payment`]: crate::ln::channelmanager::ChannelManager::send_payment
		 */
		public byte[] payment_hash;
		/**
		 * Indicates the payment was rejected for some reason by the recipient. This implies that
		 * the payment has failed, not just the route in question. If this is not set, the payment may
		 * be retried via a different route.
		 */
		public bool payment_failed_permanently;
		/**
		 * Extra error details based on the failure type. May contain an update that needs to be
		 * applied to the [`NetworkGraph`].
		 * 
		 * [`NetworkGraph`]: crate::routing::gossip::NetworkGraph
		 */
		public PathFailure failure;
		/**
		 * The payment path that failed.
		 */
		public Path path;
		/**
		 * The channel responsible for the failed payment path.
		 * 
		 * Note that for route hints or for the first hop in a path this may be an SCID alias and
		 * may not refer to a channel in the public network graph. These aliases may also collide
		 * with channels in the public network graph.
		 * 
		 * If this is `Some`, then the corresponding channel should be avoided when the payment is
		 * retried. May be `None` for older [`Event`] serializations.
		 */
		public Option_u64Z short_channel_id;
		internal Event_PaymentPathFailed(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKEvent_PaymentPathFailed_get_payment_id(ptr);
			org.ldk.structs.Option_ThirtyTwoBytesZ payment_id_hu_conv = org.ldk.structs.Option_ThirtyTwoBytesZ.constr_from_ptr(payment_id);
			if (payment_id_hu_conv != null) { payment_id_hu_conv.ptrs_to.AddLast(this); };
			this.payment_id = payment_id_hu_conv;
			long payment_hash = bindings.LDKEvent_PaymentPathFailed_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			this.payment_failed_permanently = bindings.LDKEvent_PaymentPathFailed_get_payment_failed_permanently(ptr);
			long failure = bindings.LDKEvent_PaymentPathFailed_get_failure(ptr);
			org.ldk.structs.PathFailure failure_hu_conv = org.ldk.structs.PathFailure.constr_from_ptr(failure);
			if (failure_hu_conv != null) { failure_hu_conv.ptrs_to.AddLast(this); };
			this.failure = failure_hu_conv;
			long path = bindings.LDKEvent_PaymentPathFailed_get_path(ptr);
			org.ldk.structs.Path path_hu_conv = null; if (path < 0 || path > 4096) { path_hu_conv = new org.ldk.structs.Path(null, path); }
			if (path_hu_conv != null) { path_hu_conv.ptrs_to.AddLast(this); };
			this.path = path_hu_conv;
			long short_channel_id = bindings.LDKEvent_PaymentPathFailed_get_short_channel_id(ptr);
			org.ldk.structs.Option_u64Z short_channel_id_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(short_channel_id);
			if (short_channel_id_hu_conv != null) { short_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.short_channel_id = short_channel_id_hu_conv;
		}
	}
	/** A Event of type ProbeSuccessful */
	public class Event_ProbeSuccessful : Event {
		/**
		 * The id returned by [`ChannelManager::send_probe`].
		 * 
		 * [`ChannelManager::send_probe`]: crate::ln::channelmanager::ChannelManager::send_probe
		 */
		public byte[] payment_id;
		/**
		 * The hash generated by [`ChannelManager::send_probe`].
		 * 
		 * [`ChannelManager::send_probe`]: crate::ln::channelmanager::ChannelManager::send_probe
		 */
		public byte[] payment_hash;
		/**
		 * The payment path that was successful.
		 */
		public Path path;
		internal Event_ProbeSuccessful(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKEvent_ProbeSuccessful_get_payment_id(ptr);
			byte[] payment_id_conv = InternalUtils.decodeUint8Array(payment_id);
			this.payment_id = payment_id_conv;
			long payment_hash = bindings.LDKEvent_ProbeSuccessful_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			long path = bindings.LDKEvent_ProbeSuccessful_get_path(ptr);
			org.ldk.structs.Path path_hu_conv = null; if (path < 0 || path > 4096) { path_hu_conv = new org.ldk.structs.Path(null, path); }
			if (path_hu_conv != null) { path_hu_conv.ptrs_to.AddLast(this); };
			this.path = path_hu_conv;
		}
	}
	/** A Event of type ProbeFailed */
	public class Event_ProbeFailed : Event {
		/**
		 * The id returned by [`ChannelManager::send_probe`].
		 * 
		 * [`ChannelManager::send_probe`]: crate::ln::channelmanager::ChannelManager::send_probe
		 */
		public byte[] payment_id;
		/**
		 * The hash generated by [`ChannelManager::send_probe`].
		 * 
		 * [`ChannelManager::send_probe`]: crate::ln::channelmanager::ChannelManager::send_probe
		 */
		public byte[] payment_hash;
		/**
		 * The payment path that failed.
		 */
		public Path path;
		/**
		 * The channel responsible for the failed probe.
		 * 
		 * Note that for route hints or for the first hop in a path this may be an SCID alias and
		 * may not refer to a channel in the public network graph. These aliases may also collide
		 * with channels in the public network graph.
		 */
		public Option_u64Z short_channel_id;
		internal Event_ProbeFailed(long ptr) : base(null, ptr) {
			long payment_id = bindings.LDKEvent_ProbeFailed_get_payment_id(ptr);
			byte[] payment_id_conv = InternalUtils.decodeUint8Array(payment_id);
			this.payment_id = payment_id_conv;
			long payment_hash = bindings.LDKEvent_ProbeFailed_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			long path = bindings.LDKEvent_ProbeFailed_get_path(ptr);
			org.ldk.structs.Path path_hu_conv = null; if (path < 0 || path > 4096) { path_hu_conv = new org.ldk.structs.Path(null, path); }
			if (path_hu_conv != null) { path_hu_conv.ptrs_to.AddLast(this); };
			this.path = path_hu_conv;
			long short_channel_id = bindings.LDKEvent_ProbeFailed_get_short_channel_id(ptr);
			org.ldk.structs.Option_u64Z short_channel_id_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(short_channel_id);
			if (short_channel_id_hu_conv != null) { short_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.short_channel_id = short_channel_id_hu_conv;
		}
	}
	/** A Event of type PendingHTLCsForwardable */
	public class Event_PendingHTLCsForwardable : Event {
		/**
		 * The minimum amount of time that should be waited prior to calling
		 * process_pending_htlc_forwards. To increase the effort required to correlate payments,
		 * you should wait a random amount of time in roughly the range (now + time_forwardable,
		 * now + 5*time_forwardable).
		 */
		public long time_forwardable;
		internal Event_PendingHTLCsForwardable(long ptr) : base(null, ptr) {
			this.time_forwardable = bindings.LDKEvent_PendingHTLCsForwardable_get_time_forwardable(ptr);
		}
	}
	/** A Event of type HTLCIntercepted */
	public class Event_HTLCIntercepted : Event {
		/**
		 * An id to help LDK identify which HTLC is being forwarded or failed.
		 */
		public byte[] intercept_id;
		/**
		 * The fake scid that was programmed as the next hop's scid, generated using
		 * [`ChannelManager::get_intercept_scid`].
		 * 
		 * [`ChannelManager::get_intercept_scid`]: crate::ln::channelmanager::ChannelManager::get_intercept_scid
		 */
		public long requested_next_hop_scid;
		/**
		 * The payment hash used for this HTLC.
		 */
		public byte[] payment_hash;
		/**
		 * How many msats were received on the inbound edge of this HTLC.
		 */
		public long inbound_amount_msat;
		/**
		 * How many msats the payer intended to route to the next node. Depending on the reason you are
		 * intercepting this payment, you might take a fee by forwarding less than this amount.
		 * Forwarding less than this amount may break compatibility with LDK versions prior to 0.0.116.
		 * 
		 * Note that LDK will NOT check that expected fees were factored into this value. You MUST
		 * check that whatever fee you want has been included here or subtract it as required. Further,
		 * LDK will not stop you from forwarding more than you received.
		 */
		public long expected_outbound_amount_msat;
		internal Event_HTLCIntercepted(long ptr) : base(null, ptr) {
			long intercept_id = bindings.LDKEvent_HTLCIntercepted_get_intercept_id(ptr);
			byte[] intercept_id_conv = InternalUtils.decodeUint8Array(intercept_id);
			this.intercept_id = intercept_id_conv;
			this.requested_next_hop_scid = bindings.LDKEvent_HTLCIntercepted_get_requested_next_hop_scid(ptr);
			long payment_hash = bindings.LDKEvent_HTLCIntercepted_get_payment_hash(ptr);
			byte[] payment_hash_conv = InternalUtils.decodeUint8Array(payment_hash);
			this.payment_hash = payment_hash_conv;
			this.inbound_amount_msat = bindings.LDKEvent_HTLCIntercepted_get_inbound_amount_msat(ptr);
			this.expected_outbound_amount_msat = bindings.LDKEvent_HTLCIntercepted_get_expected_outbound_amount_msat(ptr);
		}
	}
	/** A Event of type SpendableOutputs */
	public class Event_SpendableOutputs : Event {
		/**
		 * The outputs which you should store as spendable by you.
		 */
		public SpendableOutputDescriptor[] outputs;
		/**
		 * The `channel_id` indicating which channel the spendable outputs belong to.
		 * 
		 * This will always be `Some` for events generated by LDK versions 0.0.117 and above.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public ChannelId channel_id;
		internal Event_SpendableOutputs(long ptr) : base(null, ptr) {
			long outputs = bindings.LDKEvent_SpendableOutputs_get_outputs(ptr);
			int outputs_conv_27_len = InternalUtils.getArrayLength(outputs);
			SpendableOutputDescriptor[] outputs_conv_27_arr = new SpendableOutputDescriptor[outputs_conv_27_len];
			for (int b = 0; b < outputs_conv_27_len; b++) {
				long outputs_conv_27 = InternalUtils.getU64ArrayElem(outputs, b);
				org.ldk.structs.SpendableOutputDescriptor outputs_conv_27_hu_conv = org.ldk.structs.SpendableOutputDescriptor.constr_from_ptr(outputs_conv_27);
				if (outputs_conv_27_hu_conv != null) { outputs_conv_27_hu_conv.ptrs_to.AddLast(this); };
				outputs_conv_27_arr[b] = outputs_conv_27_hu_conv;
			}
			bindings.free_buffer(outputs);
			this.outputs = outputs_conv_27_arr;
			long channel_id = bindings.LDKEvent_SpendableOutputs_get_channel_id(ptr);
			org.ldk.structs.ChannelId channel_id_hu_conv = null; if (channel_id < 0 || channel_id > 4096) { channel_id_hu_conv = new org.ldk.structs.ChannelId(null, channel_id); }
			if (channel_id_hu_conv != null) { channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.channel_id = channel_id_hu_conv;
		}
	}
	/** A Event of type PaymentForwarded */
	public class Event_PaymentForwarded : Event {
		/**
		 * The channel id of the incoming channel between the previous node and us.
		 * 
		 * This is only `None` for events generated or serialized by versions prior to 0.0.107.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public ChannelId prev_channel_id;
		/**
		 * The channel id of the outgoing channel between the next node and us.
		 * 
		 * This is only `None` for events generated or serialized by versions prior to 0.0.107.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public ChannelId next_channel_id;
		/**
		 * The `user_channel_id` of the incoming channel between the previous node and us.
		 * 
		 * This is only `None` for events generated or serialized by versions prior to 0.0.122.
		 */
		public Option_U128Z prev_user_channel_id;
		/**
		 * The `user_channel_id` of the outgoing channel between the next node and us.
		 * 
		 * This will be `None` if the payment was settled via an on-chain transaction. See the
		 * caveat described for the `total_fee_earned_msat` field. Moreover it will be `None` for
		 * events generated or serialized by versions prior to 0.0.122.
		 */
		public Option_U128Z next_user_channel_id;
		/**
		 * The total fee, in milli-satoshis, which was earned as a result of the payment.
		 * 
		 * Note that if we force-closed the channel over which we forwarded an HTLC while the HTLC
		 * was pending, the amount the next hop claimed will have been rounded down to the nearest
		 * whole satoshi. Thus, the fee calculated here may be higher than expected as we still
		 * claimed the full value in millisatoshis from the source. In this case,
		 * `claim_from_onchain_tx` will be set.
		 * 
		 * If the channel which sent us the payment has been force-closed, we will claim the funds
		 * via an on-chain transaction. In that case we do not yet know the on-chain transaction
		 * fees which we will spend and will instead set this to `None`. It is possible duplicate
		 * `PaymentForwarded` events are generated for the same payment iff `total_fee_earned_msat` is
		 * `None`.
		 */
		public Option_u64Z total_fee_earned_msat;
		/**
		 * The share of the total fee, in milli-satoshis, which was withheld in addition to the
		 * forwarding fee.
		 * 
		 * This will only be `Some` if we forwarded an intercepted HTLC with less than the
		 * expected amount. This means our counterparty accepted to receive less than the invoice
		 * amount, e.g., by claiming the payment featuring a corresponding
		 * [`PaymentClaimable::counterparty_skimmed_fee_msat`].
		 * 
		 * Will also always be `None` for events serialized with LDK prior to version 0.0.122.
		 * 
		 * The caveat described above the `total_fee_earned_msat` field applies here as well.
		 * 
		 * [`PaymentClaimable::counterparty_skimmed_fee_msat`]: Self::PaymentClaimable::counterparty_skimmed_fee_msat
		 */
		public Option_u64Z skimmed_fee_msat;
		/**
		 * If this is `true`, the forwarded HTLC was claimed by our counterparty via an on-chain
		 * transaction.
		 */
		public bool claim_from_onchain_tx;
		/**
		 * The final amount forwarded, in milli-satoshis, after the fee is deducted.
		 * 
		 * The caveat described above the `total_fee_earned_msat` field applies here as well.
		 */
		public Option_u64Z outbound_amount_forwarded_msat;
		internal Event_PaymentForwarded(long ptr) : base(null, ptr) {
			long prev_channel_id = bindings.LDKEvent_PaymentForwarded_get_prev_channel_id(ptr);
			org.ldk.structs.ChannelId prev_channel_id_hu_conv = null; if (prev_channel_id < 0 || prev_channel_id > 4096) { prev_channel_id_hu_conv = new org.ldk.structs.ChannelId(null, prev_channel_id); }
			if (prev_channel_id_hu_conv != null) { prev_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.prev_channel_id = prev_channel_id_hu_conv;
			long next_channel_id = bindings.LDKEvent_PaymentForwarded_get_next_channel_id(ptr);
			org.ldk.structs.ChannelId next_channel_id_hu_conv = null; if (next_channel_id < 0 || next_channel_id > 4096) { next_channel_id_hu_conv = new org.ldk.structs.ChannelId(null, next_channel_id); }
			if (next_channel_id_hu_conv != null) { next_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.next_channel_id = next_channel_id_hu_conv;
			long prev_user_channel_id = bindings.LDKEvent_PaymentForwarded_get_prev_user_channel_id(ptr);
			org.ldk.structs.Option_U128Z prev_user_channel_id_hu_conv = org.ldk.structs.Option_U128Z.constr_from_ptr(prev_user_channel_id);
			if (prev_user_channel_id_hu_conv != null) { prev_user_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.prev_user_channel_id = prev_user_channel_id_hu_conv;
			long next_user_channel_id = bindings.LDKEvent_PaymentForwarded_get_next_user_channel_id(ptr);
			org.ldk.structs.Option_U128Z next_user_channel_id_hu_conv = org.ldk.structs.Option_U128Z.constr_from_ptr(next_user_channel_id);
			if (next_user_channel_id_hu_conv != null) { next_user_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.next_user_channel_id = next_user_channel_id_hu_conv;
			long total_fee_earned_msat = bindings.LDKEvent_PaymentForwarded_get_total_fee_earned_msat(ptr);
			org.ldk.structs.Option_u64Z total_fee_earned_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(total_fee_earned_msat);
			if (total_fee_earned_msat_hu_conv != null) { total_fee_earned_msat_hu_conv.ptrs_to.AddLast(this); };
			this.total_fee_earned_msat = total_fee_earned_msat_hu_conv;
			long skimmed_fee_msat = bindings.LDKEvent_PaymentForwarded_get_skimmed_fee_msat(ptr);
			org.ldk.structs.Option_u64Z skimmed_fee_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(skimmed_fee_msat);
			if (skimmed_fee_msat_hu_conv != null) { skimmed_fee_msat_hu_conv.ptrs_to.AddLast(this); };
			this.skimmed_fee_msat = skimmed_fee_msat_hu_conv;
			this.claim_from_onchain_tx = bindings.LDKEvent_PaymentForwarded_get_claim_from_onchain_tx(ptr);
			long outbound_amount_forwarded_msat = bindings.LDKEvent_PaymentForwarded_get_outbound_amount_forwarded_msat(ptr);
			org.ldk.structs.Option_u64Z outbound_amount_forwarded_msat_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(outbound_amount_forwarded_msat);
			if (outbound_amount_forwarded_msat_hu_conv != null) { outbound_amount_forwarded_msat_hu_conv.ptrs_to.AddLast(this); };
			this.outbound_amount_forwarded_msat = outbound_amount_forwarded_msat_hu_conv;
		}
	}
	/** A Event of type ChannelPending */
	public class Event_ChannelPending : Event {
		/**
		 * The `channel_id` of the channel that is pending confirmation.
		 */
		public ChannelId channel_id;
		/**
		 * The `user_channel_id` value passed in to [`ChannelManager::create_channel`] for outbound
		 * channels, or to [`ChannelManager::accept_inbound_channel`] for inbound channels if
		 * [`UserConfig::manually_accept_inbound_channels`] config flag is set to true. Otherwise
		 * `user_channel_id` will be randomized for an inbound channel.
		 * 
		 * [`ChannelManager::create_channel`]: crate::ln::channelmanager::ChannelManager::create_channel
		 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
		 * [`UserConfig::manually_accept_inbound_channels`]: crate::util::config::UserConfig::manually_accept_inbound_channels
		 */
		public UInt128 user_channel_id;
		/**
		 * The `temporary_channel_id` this channel used to be known by during channel establishment.
		 * 
		 * Will be `None` for channels created prior to LDK version 0.0.115.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public ChannelId former_temporary_channel_id;
		/**
		 * The `node_id` of the channel counterparty.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The outpoint of the channel's funding transaction.
		 */
		public OutPoint funding_txo;
		/**
		 * The features that this channel will operate with.
		 * 
		 * Will be `None` for channels created prior to LDK version 0.0.122.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public ChannelTypeFeatures channel_type;
		internal Event_ChannelPending(long ptr) : base(null, ptr) {
			long channel_id = bindings.LDKEvent_ChannelPending_get_channel_id(ptr);
			org.ldk.structs.ChannelId channel_id_hu_conv = null; if (channel_id < 0 || channel_id > 4096) { channel_id_hu_conv = new org.ldk.structs.ChannelId(null, channel_id); }
			if (channel_id_hu_conv != null) { channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.channel_id = channel_id_hu_conv;
			long user_channel_id = bindings.LDKEvent_ChannelPending_get_user_channel_id(ptr);
			org.ldk.util.UInt128 user_channel_id_conv = new org.ldk.util.UInt128(user_channel_id);
			this.user_channel_id = user_channel_id_conv;
			long former_temporary_channel_id = bindings.LDKEvent_ChannelPending_get_former_temporary_channel_id(ptr);
			org.ldk.structs.ChannelId former_temporary_channel_id_hu_conv = null; if (former_temporary_channel_id < 0 || former_temporary_channel_id > 4096) { former_temporary_channel_id_hu_conv = new org.ldk.structs.ChannelId(null, former_temporary_channel_id); }
			if (former_temporary_channel_id_hu_conv != null) { former_temporary_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.former_temporary_channel_id = former_temporary_channel_id_hu_conv;
			long counterparty_node_id = bindings.LDKEvent_ChannelPending_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long funding_txo = bindings.LDKEvent_ChannelPending_get_funding_txo(ptr);
			org.ldk.structs.OutPoint funding_txo_hu_conv = null; if (funding_txo < 0 || funding_txo > 4096) { funding_txo_hu_conv = new org.ldk.structs.OutPoint(null, funding_txo); }
			if (funding_txo_hu_conv != null) { funding_txo_hu_conv.ptrs_to.AddLast(this); };
			this.funding_txo = funding_txo_hu_conv;
			long channel_type = bindings.LDKEvent_ChannelPending_get_channel_type(ptr);
			org.ldk.structs.ChannelTypeFeatures channel_type_hu_conv = null; if (channel_type < 0 || channel_type > 4096) { channel_type_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, channel_type); }
			if (channel_type_hu_conv != null) { channel_type_hu_conv.ptrs_to.AddLast(this); };
			this.channel_type = channel_type_hu_conv;
		}
	}
	/** A Event of type ChannelReady */
	public class Event_ChannelReady : Event {
		/**
		 * The `channel_id` of the channel that is ready.
		 */
		public ChannelId channel_id;
		/**
		 * The `user_channel_id` value passed in to [`ChannelManager::create_channel`] for outbound
		 * channels, or to [`ChannelManager::accept_inbound_channel`] for inbound channels if
		 * [`UserConfig::manually_accept_inbound_channels`] config flag is set to true. Otherwise
		 * `user_channel_id` will be randomized for an inbound channel.
		 * 
		 * [`ChannelManager::create_channel`]: crate::ln::channelmanager::ChannelManager::create_channel
		 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
		 * [`UserConfig::manually_accept_inbound_channels`]: crate::util::config::UserConfig::manually_accept_inbound_channels
		 */
		public UInt128 user_channel_id;
		/**
		 * The `node_id` of the channel counterparty.
		 */
		public byte[] counterparty_node_id;
		/**
		 * The features that this channel will operate with.
		 */
		public ChannelTypeFeatures channel_type;
		internal Event_ChannelReady(long ptr) : base(null, ptr) {
			long channel_id = bindings.LDKEvent_ChannelReady_get_channel_id(ptr);
			org.ldk.structs.ChannelId channel_id_hu_conv = null; if (channel_id < 0 || channel_id > 4096) { channel_id_hu_conv = new org.ldk.structs.ChannelId(null, channel_id); }
			if (channel_id_hu_conv != null) { channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.channel_id = channel_id_hu_conv;
			long user_channel_id = bindings.LDKEvent_ChannelReady_get_user_channel_id(ptr);
			org.ldk.util.UInt128 user_channel_id_conv = new org.ldk.util.UInt128(user_channel_id);
			this.user_channel_id = user_channel_id_conv;
			long counterparty_node_id = bindings.LDKEvent_ChannelReady_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long channel_type = bindings.LDKEvent_ChannelReady_get_channel_type(ptr);
			org.ldk.structs.ChannelTypeFeatures channel_type_hu_conv = null; if (channel_type < 0 || channel_type > 4096) { channel_type_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, channel_type); }
			if (channel_type_hu_conv != null) { channel_type_hu_conv.ptrs_to.AddLast(this); };
			this.channel_type = channel_type_hu_conv;
		}
	}
	/** A Event of type ChannelClosed */
	public class Event_ChannelClosed : Event {
		/**
		 * The `channel_id` of the channel which has been closed. Note that on-chain transactions
		 * resolving the channel are likely still awaiting confirmation.
		 */
		public ChannelId channel_id;
		/**
		 * The `user_channel_id` value passed in to [`ChannelManager::create_channel`] for outbound
		 * channels, or to [`ChannelManager::accept_inbound_channel`] for inbound channels if
		 * [`UserConfig::manually_accept_inbound_channels`] config flag is set to true. Otherwise
		 * `user_channel_id` will be randomized for inbound channels.
		 * This may be zero for inbound channels serialized prior to 0.0.113 and will always be
		 * zero for objects serialized with LDK versions prior to 0.0.102.
		 * 
		 * [`ChannelManager::create_channel`]: crate::ln::channelmanager::ChannelManager::create_channel
		 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
		 * [`UserConfig::manually_accept_inbound_channels`]: crate::util::config::UserConfig::manually_accept_inbound_channels
		 */
		public UInt128 user_channel_id;
		/**
		 * The reason the channel was closed.
		 */
		public ClosureReason reason;
		/**
		 * Counterparty in the closed channel.
		 * 
		 * This field will be `None` for objects serialized prior to LDK 0.0.117.
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public byte[] counterparty_node_id;
		/**
		 * Channel capacity of the closing channel (sats).
		 * 
		 * This field will be `None` for objects serialized prior to LDK 0.0.117.
		 */
		public Option_u64Z channel_capacity_sats;
		/**
		 * The original channel funding TXO; this helps checking for the existence and confirmation
		 * status of the closing tx.
		 * Note that for instances serialized in v0.0.119 or prior this will be missing (None).
		 * 
		 * Note that this (or a relevant inner pointer) may be NULL or all-0s to represent None
		 */
		public OutPoint channel_funding_txo;
		internal Event_ChannelClosed(long ptr) : base(null, ptr) {
			long channel_id = bindings.LDKEvent_ChannelClosed_get_channel_id(ptr);
			org.ldk.structs.ChannelId channel_id_hu_conv = null; if (channel_id < 0 || channel_id > 4096) { channel_id_hu_conv = new org.ldk.structs.ChannelId(null, channel_id); }
			if (channel_id_hu_conv != null) { channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.channel_id = channel_id_hu_conv;
			long user_channel_id = bindings.LDKEvent_ChannelClosed_get_user_channel_id(ptr);
			org.ldk.util.UInt128 user_channel_id_conv = new org.ldk.util.UInt128(user_channel_id);
			this.user_channel_id = user_channel_id_conv;
			long reason = bindings.LDKEvent_ChannelClosed_get_reason(ptr);
			org.ldk.structs.ClosureReason reason_hu_conv = org.ldk.structs.ClosureReason.constr_from_ptr(reason);
			if (reason_hu_conv != null) { reason_hu_conv.ptrs_to.AddLast(this); };
			this.reason = reason_hu_conv;
			long counterparty_node_id = bindings.LDKEvent_ChannelClosed_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			long channel_capacity_sats = bindings.LDKEvent_ChannelClosed_get_channel_capacity_sats(ptr);
			org.ldk.structs.Option_u64Z channel_capacity_sats_hu_conv = org.ldk.structs.Option_u64Z.constr_from_ptr(channel_capacity_sats);
			if (channel_capacity_sats_hu_conv != null) { channel_capacity_sats_hu_conv.ptrs_to.AddLast(this); };
			this.channel_capacity_sats = channel_capacity_sats_hu_conv;
			long channel_funding_txo = bindings.LDKEvent_ChannelClosed_get_channel_funding_txo(ptr);
			org.ldk.structs.OutPoint channel_funding_txo_hu_conv = null; if (channel_funding_txo < 0 || channel_funding_txo > 4096) { channel_funding_txo_hu_conv = new org.ldk.structs.OutPoint(null, channel_funding_txo); }
			if (channel_funding_txo_hu_conv != null) { channel_funding_txo_hu_conv.ptrs_to.AddLast(this); };
			this.channel_funding_txo = channel_funding_txo_hu_conv;
		}
	}
	/** A Event of type DiscardFunding */
	public class Event_DiscardFunding : Event {
		/**
		 * The channel_id of the channel which has been closed.
		 */
		public ChannelId channel_id;
		/**
		 * The full transaction received from the user
		 */
		public byte[] transaction;
		internal Event_DiscardFunding(long ptr) : base(null, ptr) {
			long channel_id = bindings.LDKEvent_DiscardFunding_get_channel_id(ptr);
			org.ldk.structs.ChannelId channel_id_hu_conv = null; if (channel_id < 0 || channel_id > 4096) { channel_id_hu_conv = new org.ldk.structs.ChannelId(null, channel_id); }
			if (channel_id_hu_conv != null) { channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.channel_id = channel_id_hu_conv;
			long transaction = bindings.LDKEvent_DiscardFunding_get_transaction(ptr);
			byte[] transaction_conv = InternalUtils.decodeUint8Array(transaction);
			this.transaction = transaction_conv;
		}
	}
	/** A Event of type OpenChannelRequest */
	public class Event_OpenChannelRequest : Event {
		/**
		 * The temporary channel ID of the channel requested to be opened.
		 * 
		 * When responding to the request, the `temporary_channel_id` should be passed
		 * back to the ChannelManager through [`ChannelManager::accept_inbound_channel`] to accept,
		 * or through [`ChannelManager::force_close_without_broadcasting_txn`] to reject.
		 * 
		 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
		 * [`ChannelManager::force_close_without_broadcasting_txn`]: crate::ln::channelmanager::ChannelManager::force_close_without_broadcasting_txn
		 */
		public ChannelId temporary_channel_id;
		/**
		 * The node_id of the counterparty requesting to open the channel.
		 * 
		 * When responding to the request, the `counterparty_node_id` should be passed
		 * back to the `ChannelManager` through [`ChannelManager::accept_inbound_channel`] to
		 * accept the request, or through [`ChannelManager::force_close_without_broadcasting_txn`] to reject the
		 * request.
		 * 
		 * [`ChannelManager::accept_inbound_channel`]: crate::ln::channelmanager::ChannelManager::accept_inbound_channel
		 * [`ChannelManager::force_close_without_broadcasting_txn`]: crate::ln::channelmanager::ChannelManager::force_close_without_broadcasting_txn
		 */
		public byte[] counterparty_node_id;
		/**
		 * The channel value of the requested channel.
		 */
		public long funding_satoshis;
		/**
		 * Our starting balance in the channel if the request is accepted, in milli-satoshi.
		 */
		public long push_msat;
		/**
		 * The features that this channel will operate with. If you reject the channel, a
		 * well-behaved counterparty may automatically re-attempt the channel with a new set of
		 * feature flags.
		 * 
		 * Note that if [`ChannelTypeFeatures::supports_scid_privacy`] returns true on this type,
		 * the resulting [`ChannelManager`] will not be readable by versions of LDK prior to
		 * 0.0.106.
		 * 
		 * Furthermore, note that if [`ChannelTypeFeatures::supports_zero_conf`] returns true on this type,
		 * the resulting [`ChannelManager`] will not be readable by versions of LDK prior to
		 * 0.0.107. Channels setting this type also need to get manually accepted via
		 * [`crate::ln::channelmanager::ChannelManager::accept_inbound_channel_from_trusted_peer_0conf`],
		 * or will be rejected otherwise.
		 * 
		 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
		 */
		public ChannelTypeFeatures channel_type;
		internal Event_OpenChannelRequest(long ptr) : base(null, ptr) {
			long temporary_channel_id = bindings.LDKEvent_OpenChannelRequest_get_temporary_channel_id(ptr);
			org.ldk.structs.ChannelId temporary_channel_id_hu_conv = null; if (temporary_channel_id < 0 || temporary_channel_id > 4096) { temporary_channel_id_hu_conv = new org.ldk.structs.ChannelId(null, temporary_channel_id); }
			if (temporary_channel_id_hu_conv != null) { temporary_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.temporary_channel_id = temporary_channel_id_hu_conv;
			long counterparty_node_id = bindings.LDKEvent_OpenChannelRequest_get_counterparty_node_id(ptr);
			byte[] counterparty_node_id_conv = InternalUtils.decodeUint8Array(counterparty_node_id);
			this.counterparty_node_id = counterparty_node_id_conv;
			this.funding_satoshis = bindings.LDKEvent_OpenChannelRequest_get_funding_satoshis(ptr);
			this.push_msat = bindings.LDKEvent_OpenChannelRequest_get_push_msat(ptr);
			long channel_type = bindings.LDKEvent_OpenChannelRequest_get_channel_type(ptr);
			org.ldk.structs.ChannelTypeFeatures channel_type_hu_conv = null; if (channel_type < 0 || channel_type > 4096) { channel_type_hu_conv = new org.ldk.structs.ChannelTypeFeatures(null, channel_type); }
			if (channel_type_hu_conv != null) { channel_type_hu_conv.ptrs_to.AddLast(this); };
			this.channel_type = channel_type_hu_conv;
		}
	}
	/** A Event of type HTLCHandlingFailed */
	public class Event_HTLCHandlingFailed : Event {
		/**
		 * The channel over which the HTLC was received.
		 */
		public ChannelId prev_channel_id;
		/**
		 * Destination of the HTLC that failed to be processed.
		 */
		public HTLCDestination failed_next_destination;
		internal Event_HTLCHandlingFailed(long ptr) : base(null, ptr) {
			long prev_channel_id = bindings.LDKEvent_HTLCHandlingFailed_get_prev_channel_id(ptr);
			org.ldk.structs.ChannelId prev_channel_id_hu_conv = null; if (prev_channel_id < 0 || prev_channel_id > 4096) { prev_channel_id_hu_conv = new org.ldk.structs.ChannelId(null, prev_channel_id); }
			if (prev_channel_id_hu_conv != null) { prev_channel_id_hu_conv.ptrs_to.AddLast(this); };
			this.prev_channel_id = prev_channel_id_hu_conv;
			long failed_next_destination = bindings.LDKEvent_HTLCHandlingFailed_get_failed_next_destination(ptr);
			org.ldk.structs.HTLCDestination failed_next_destination_hu_conv = org.ldk.structs.HTLCDestination.constr_from_ptr(failed_next_destination);
			if (failed_next_destination_hu_conv != null) { failed_next_destination_hu_conv.ptrs_to.AddLast(this); };
			this.failed_next_destination = failed_next_destination_hu_conv;
		}
	}
	/** A Event of type BumpTransaction */
	public class Event_BumpTransaction : Event {
		public BumpTransactionEvent bump_transaction;
		internal Event_BumpTransaction(long ptr) : base(null, ptr) {
			long bump_transaction = bindings.LDKEvent_BumpTransaction_get_bump_transaction(ptr);
			org.ldk.structs.BumpTransactionEvent bump_transaction_hu_conv = org.ldk.structs.BumpTransactionEvent.constr_from_ptr(bump_transaction);
			if (bump_transaction_hu_conv != null) { bump_transaction_hu_conv.ptrs_to.AddLast(this); };
			this.bump_transaction = bump_transaction_hu_conv;
		}
	}
	internal long clone_ptr() {
		long ret = bindings.Event_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the Event
	 */
	public Event clone() {
		long ret = bindings.Event_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new FundingGenerationReady-variant Event
	 */
	public static Event funding_generation_ready(org.ldk.structs.ChannelId temporary_channel_id, byte[] counterparty_node_id, long channel_value_satoshis, byte[] output_script, org.ldk.util.UInt128 user_channel_id) {
		long ret = bindings.Event_funding_generation_ready(temporary_channel_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), channel_value_satoshis, InternalUtils.encodeUint8Array(output_script), InternalUtils.encodeUint8Array(user_channel_id.getLEBytes()));
		GC.KeepAlive(temporary_channel_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(channel_value_satoshis);
		GC.KeepAlive(output_script);
		GC.KeepAlive(user_channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(temporary_channel_id); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PaymentClaimable-variant Event
	 */
	public static Event payment_claimable(byte[] receiver_node_id, byte[] payment_hash, org.ldk.structs.RecipientOnionFields onion_fields, long amount_msat, long counterparty_skimmed_fee_msat, org.ldk.structs.PaymentPurpose purpose, org.ldk.structs.ChannelId via_channel_id, org.ldk.structs.Option_U128Z via_user_channel_id, org.ldk.structs.Option_u32Z claim_deadline) {
		long ret = bindings.Event_payment_claimable(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(receiver_node_id, 33)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), onion_fields.ptr, amount_msat, counterparty_skimmed_fee_msat, purpose.ptr, via_channel_id.ptr, via_user_channel_id.ptr, claim_deadline.ptr);
		GC.KeepAlive(receiver_node_id);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(onion_fields);
		GC.KeepAlive(amount_msat);
		GC.KeepAlive(counterparty_skimmed_fee_msat);
		GC.KeepAlive(purpose);
		GC.KeepAlive(via_channel_id);
		GC.KeepAlive(via_user_channel_id);
		GC.KeepAlive(claim_deadline);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(onion_fields); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(purpose); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(via_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(via_user_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(claim_deadline); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PaymentClaimed-variant Event
	 */
	public static Event payment_claimed(byte[] receiver_node_id, byte[] payment_hash, long amount_msat, org.ldk.structs.PaymentPurpose purpose, ClaimedHTLC[] htlcs, org.ldk.structs.Option_u64Z sender_intended_total_msat) {
		long ret = bindings.Event_payment_claimed(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(receiver_node_id, 33)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), amount_msat, purpose.ptr, InternalUtils.encodeUint64Array(InternalUtils.mapArray(htlcs, htlcs_conv_13 => htlcs_conv_13.ptr)), sender_intended_total_msat.ptr);
		GC.KeepAlive(receiver_node_id);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(amount_msat);
		GC.KeepAlive(purpose);
		GC.KeepAlive(htlcs);
		GC.KeepAlive(sender_intended_total_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(purpose); };
		foreach (ClaimedHTLC htlcs_conv_13 in htlcs) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(htlcs_conv_13); }; };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(sender_intended_total_msat); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ConnectionNeeded-variant Event
	 */
	public static Event connection_needed(byte[] node_id, SocketAddress[] addresses) {
		long ret = bindings.Event_connection_needed(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(node_id, 33)), InternalUtils.encodeUint64Array(InternalUtils.mapArray(addresses, addresses_conv_15 => addresses_conv_15.ptr)));
		GC.KeepAlive(node_id);
		GC.KeepAlive(addresses);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		foreach (SocketAddress addresses_conv_15 in addresses) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(addresses_conv_15); }; };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new InvoiceRequestFailed-variant Event
	 */
	public static Event invoice_request_failed(byte[] payment_id) {
		long ret = bindings.Event_invoice_request_failed(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_id, 32)));
		GC.KeepAlive(payment_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PaymentSent-variant Event
	 */
	public static Event payment_sent(org.ldk.structs.Option_ThirtyTwoBytesZ payment_id, byte[] payment_preimage, byte[] payment_hash, org.ldk.structs.Option_u64Z fee_paid_msat) {
		long ret = bindings.Event_payment_sent(payment_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_preimage, 32)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), fee_paid_msat.ptr);
		GC.KeepAlive(payment_id);
		GC.KeepAlive(payment_preimage);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(fee_paid_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(payment_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(fee_paid_msat); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PaymentFailed-variant Event
	 */
	public static Event payment_failed(byte[] payment_id, byte[] payment_hash, org.ldk.structs.Option_PaymentFailureReasonZ reason) {
		long ret = bindings.Event_payment_failed(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_id, 32)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), reason.ptr);
		GC.KeepAlive(payment_id);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(reason);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(reason); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PaymentPathSuccessful-variant Event
	 */
	public static Event payment_path_successful(byte[] payment_id, org.ldk.structs.Option_ThirtyTwoBytesZ payment_hash, org.ldk.structs.Path path) {
		long ret = bindings.Event_payment_path_successful(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_id, 32)), payment_hash.ptr, path.ptr);
		GC.KeepAlive(payment_id);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(path);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(payment_hash); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(path); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PaymentPathFailed-variant Event
	 */
	public static Event payment_path_failed(org.ldk.structs.Option_ThirtyTwoBytesZ payment_id, byte[] payment_hash, bool payment_failed_permanently, org.ldk.structs.PathFailure failure, org.ldk.structs.Path path, org.ldk.structs.Option_u64Z short_channel_id) {
		long ret = bindings.Event_payment_path_failed(payment_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), payment_failed_permanently, failure.ptr, path.ptr, short_channel_id.ptr);
		GC.KeepAlive(payment_id);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(payment_failed_permanently);
		GC.KeepAlive(failure);
		GC.KeepAlive(path);
		GC.KeepAlive(short_channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(payment_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(failure); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(path); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(short_channel_id); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ProbeSuccessful-variant Event
	 */
	public static Event probe_successful(byte[] payment_id, byte[] payment_hash, org.ldk.structs.Path path) {
		long ret = bindings.Event_probe_successful(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_id, 32)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), path.ptr);
		GC.KeepAlive(payment_id);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(path);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(path); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ProbeFailed-variant Event
	 */
	public static Event probe_failed(byte[] payment_id, byte[] payment_hash, org.ldk.structs.Path path, org.ldk.structs.Option_u64Z short_channel_id) {
		long ret = bindings.Event_probe_failed(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_id, 32)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), path.ptr, short_channel_id.ptr);
		GC.KeepAlive(payment_id);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(path);
		GC.KeepAlive(short_channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(path); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(short_channel_id); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PendingHTLCsForwardable-variant Event
	 */
	public static Event pending_htlcs_forwardable(long time_forwardable) {
		long ret = bindings.Event_pending_htlcs_forwardable(time_forwardable);
		GC.KeepAlive(time_forwardable);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new HTLCIntercepted-variant Event
	 */
	public static Event htlcintercepted(byte[] intercept_id, long requested_next_hop_scid, byte[] payment_hash, long inbound_amount_msat, long expected_outbound_amount_msat) {
		long ret = bindings.Event_htlcintercepted(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(intercept_id, 32)), requested_next_hop_scid, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_hash, 32)), inbound_amount_msat, expected_outbound_amount_msat);
		GC.KeepAlive(intercept_id);
		GC.KeepAlive(requested_next_hop_scid);
		GC.KeepAlive(payment_hash);
		GC.KeepAlive(inbound_amount_msat);
		GC.KeepAlive(expected_outbound_amount_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new SpendableOutputs-variant Event
	 */
	public static Event spendable_outputs(SpendableOutputDescriptor[] outputs, org.ldk.structs.ChannelId channel_id) {
		long ret = bindings.Event_spendable_outputs(InternalUtils.encodeUint64Array(InternalUtils.mapArray(outputs, outputs_conv_27 => outputs_conv_27.ptr)), channel_id.ptr);
		GC.KeepAlive(outputs);
		GC.KeepAlive(channel_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		foreach (SpendableOutputDescriptor outputs_conv_27 in outputs) { if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(outputs_conv_27); }; };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_id); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new PaymentForwarded-variant Event
	 */
	public static Event payment_forwarded(org.ldk.structs.ChannelId prev_channel_id, org.ldk.structs.ChannelId next_channel_id, org.ldk.structs.Option_U128Z prev_user_channel_id, org.ldk.structs.Option_U128Z next_user_channel_id, org.ldk.structs.Option_u64Z total_fee_earned_msat, org.ldk.structs.Option_u64Z skimmed_fee_msat, bool claim_from_onchain_tx, org.ldk.structs.Option_u64Z outbound_amount_forwarded_msat) {
		long ret = bindings.Event_payment_forwarded(prev_channel_id.ptr, next_channel_id.ptr, prev_user_channel_id.ptr, next_user_channel_id.ptr, total_fee_earned_msat.ptr, skimmed_fee_msat.ptr, claim_from_onchain_tx, outbound_amount_forwarded_msat.ptr);
		GC.KeepAlive(prev_channel_id);
		GC.KeepAlive(next_channel_id);
		GC.KeepAlive(prev_user_channel_id);
		GC.KeepAlive(next_user_channel_id);
		GC.KeepAlive(total_fee_earned_msat);
		GC.KeepAlive(skimmed_fee_msat);
		GC.KeepAlive(claim_from_onchain_tx);
		GC.KeepAlive(outbound_amount_forwarded_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(prev_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(next_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(prev_user_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(next_user_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(total_fee_earned_msat); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(skimmed_fee_msat); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(outbound_amount_forwarded_msat); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ChannelPending-variant Event
	 */
	public static Event channel_pending(org.ldk.structs.ChannelId channel_id, org.ldk.util.UInt128 user_channel_id, org.ldk.structs.ChannelId former_temporary_channel_id, byte[] counterparty_node_id, org.ldk.structs.OutPoint funding_txo, org.ldk.structs.ChannelTypeFeatures channel_type) {
		long ret = bindings.Event_channel_pending(channel_id.ptr, InternalUtils.encodeUint8Array(user_channel_id.getLEBytes()), former_temporary_channel_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), funding_txo.ptr, channel_type.ptr);
		GC.KeepAlive(channel_id);
		GC.KeepAlive(user_channel_id);
		GC.KeepAlive(former_temporary_channel_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(funding_txo);
		GC.KeepAlive(channel_type);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(former_temporary_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(funding_txo); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_type); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ChannelReady-variant Event
	 */
	public static Event channel_ready(org.ldk.structs.ChannelId channel_id, org.ldk.util.UInt128 user_channel_id, byte[] counterparty_node_id, org.ldk.structs.ChannelTypeFeatures channel_type) {
		long ret = bindings.Event_channel_ready(channel_id.ptr, InternalUtils.encodeUint8Array(user_channel_id.getLEBytes()), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), channel_type.ptr);
		GC.KeepAlive(channel_id);
		GC.KeepAlive(user_channel_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(channel_type);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_type); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new ChannelClosed-variant Event
	 */
	public static Event channel_closed(org.ldk.structs.ChannelId channel_id, org.ldk.util.UInt128 user_channel_id, org.ldk.structs.ClosureReason reason, byte[] counterparty_node_id, org.ldk.structs.Option_u64Z channel_capacity_sats, org.ldk.structs.OutPoint channel_funding_txo) {
		long ret = bindings.Event_channel_closed(channel_id.ptr, InternalUtils.encodeUint8Array(user_channel_id.getLEBytes()), reason.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), channel_capacity_sats.ptr, channel_funding_txo.ptr);
		GC.KeepAlive(channel_id);
		GC.KeepAlive(user_channel_id);
		GC.KeepAlive(reason);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(channel_capacity_sats);
		GC.KeepAlive(channel_funding_txo);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(reason); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_capacity_sats); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_funding_txo); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new DiscardFunding-variant Event
	 */
	public static Event discard_funding(org.ldk.structs.ChannelId channel_id, byte[] transaction) {
		long ret = bindings.Event_discard_funding(channel_id.ptr, InternalUtils.encodeUint8Array(transaction));
		GC.KeepAlive(channel_id);
		GC.KeepAlive(transaction);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_id); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new OpenChannelRequest-variant Event
	 */
	public static Event open_channel_request(org.ldk.structs.ChannelId temporary_channel_id, byte[] counterparty_node_id, long funding_satoshis, long push_msat, org.ldk.structs.ChannelTypeFeatures channel_type) {
		long ret = bindings.Event_open_channel_request(temporary_channel_id.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(counterparty_node_id, 33)), funding_satoshis, push_msat, channel_type.ptr);
		GC.KeepAlive(temporary_channel_id);
		GC.KeepAlive(counterparty_node_id);
		GC.KeepAlive(funding_satoshis);
		GC.KeepAlive(push_msat);
		GC.KeepAlive(channel_type);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(temporary_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(channel_type); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new HTLCHandlingFailed-variant Event
	 */
	public static Event htlchandling_failed(org.ldk.structs.ChannelId prev_channel_id, org.ldk.structs.HTLCDestination failed_next_destination) {
		long ret = bindings.Event_htlchandling_failed(prev_channel_id.ptr, failed_next_destination.ptr);
		GC.KeepAlive(prev_channel_id);
		GC.KeepAlive(failed_next_destination);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(prev_channel_id); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(failed_next_destination); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new BumpTransaction-variant Event
	 */
	public static Event bump_transaction(org.ldk.structs.BumpTransactionEvent a) {
		long ret = bindings.Event_bump_transaction(a.ptr);
		GC.KeepAlive(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Event ret_hu_conv = org.ldk.structs.Event.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(a); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two Events contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public bool eq(org.ldk.structs.Event b) {
		bool ret = bindings.Event_eq(this.ptr, b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is Event)) return false;
		return this.eq((Event)o);
	}
	/**
	 * Serialize the Event object into a byte array which can be read by Event_read
	 */
	public byte[] write() {
		long ret = bindings.Event_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

}
} } }
