package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Simple implementation of [`EntropySource`], [`NodeSigner`], and [`SignerProvider`] that takes a
 * 32-byte seed for use as a BIP 32 extended key and derives keys from that.
 * 
 * Your `node_id` is seed/0'.
 * Unilateral closes may use seed/1'.
 * Cooperative closes may use seed/2'.
 * The two close keys may be needed to claim on-chain funds!
 * 
 * This struct cannot be used for nodes that wish to support receiving phantom payments;
 * [`PhantomKeysManager`] must be used instead.
 * 
 * Note that switching between this struct and [`PhantomKeysManager`] will invalidate any
 * previously issued invoices and attempts to pay previous invoices will fail.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class KeysManager extends CommonBase {
	KeysManager(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.KeysManager_free(ptr); }
	}

	/**
	 * Constructs a [`KeysManager`] from a 32-byte seed. If the seed is in some way biased (e.g.,
	 * your CSRNG is busted) this may panic (but more importantly, you will possibly lose funds).
	 * `starting_time` isn't strictly required to actually be a time, but it must absolutely,
	 * without a doubt, be unique to this instance. ie if you start multiple times with the same
	 * `seed`, `starting_time` must be unique to each run. Thus, the easiest way to achieve this
	 * is to simply use the current time (with very high precision).
	 * 
	 * The `seed` MUST be backed up safely prior to use so that the keys can be re-created, however,
	 * obviously, `starting_time` should be unique every time you reload the library - it is only
	 * used to generate new ephemeral key data (which will be stored by the individual channel if
	 * necessary).
	 * 
	 * Note that the seed is required to recover certain on-chain funds independent of
	 * [`ChannelMonitor`] data, though a current copy of [`ChannelMonitor`] data is also required
	 * for any channel, and some on-chain during-closing funds.
	 * 
	 * [`ChannelMonitor`]: crate::chain::channelmonitor::ChannelMonitor
	 */
	public static KeysManager of(byte[] seed, long starting_time_secs, int starting_time_nanos) {
		long ret = bindings.KeysManager_new(InternalUtils.check_arr_len(seed, 32), starting_time_secs, starting_time_nanos);
		Reference.reachabilityFence(seed);
		Reference.reachabilityFence(starting_time_secs);
		Reference.reachabilityFence(starting_time_nanos);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.KeysManager ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.KeysManager(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Gets the \"node_id\" secret key used to sign gossip announcements, decode onion data, etc.
	 */
	public byte[] get_node_secret_key() {
		byte[] ret = bindings.KeysManager_get_node_secret_key(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Derive an old [`WriteableEcdsaChannelSigner`] containing per-channel secrets based on a key derivation parameters.
	 */
	public InMemorySigner derive_channel_keys(long channel_value_satoshis, byte[] params) {
		long ret = bindings.KeysManager_derive_channel_keys(this.ptr, channel_value_satoshis, InternalUtils.check_arr_len(params, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(channel_value_satoshis);
		Reference.reachabilityFence(params);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.InMemorySigner ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.InMemorySigner(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Signs the given [`PartiallySignedTransaction`] which spends the given [`SpendableOutputDescriptor`]s.
	 * The resulting inputs will be finalized and the PSBT will be ready for broadcast if there
	 * are no other inputs that need signing.
	 * 
	 * Returns `Err(())` if the PSBT is missing a descriptor or if we fail to sign.
	 * 
	 * May panic if the [`SpendableOutputDescriptor`]s were not generated by channels which used
	 * this [`KeysManager`] or one of the [`InMemorySigner`] created by this [`KeysManager`].
	 */
	public Result_CVec_u8ZNoneZ sign_spendable_outputs_psbt(SpendableOutputDescriptor[] descriptors, byte[] psbt) {
		long ret = bindings.KeysManager_sign_spendable_outputs_psbt(this.ptr, descriptors != null ? Arrays.stream(descriptors).mapToLong(descriptors_conv_27 -> descriptors_conv_27.ptr).toArray() : null, psbt);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(descriptors);
		Reference.reachabilityFence(psbt);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_CVec_u8ZNoneZ ret_hu_conv = Result_CVec_u8ZNoneZ.constr_from_ptr(ret);
		for (SpendableOutputDescriptor descriptors_conv_27: descriptors) { if (this != null) { this.ptrs_to.add(descriptors_conv_27); }; };
		return ret_hu_conv;
	}

	/**
	 * Creates a [`Transaction`] which spends the given descriptors to the given outputs, plus an
	 * output to the given change destination (if sufficient change value remains). The
	 * transaction will have a feerate, at least, of the given value.
	 * 
	 * The `locktime` argument is used to set the transaction's locktime. If `None`, the
	 * transaction will have a locktime of 0. It it recommended to set this to the current block
	 * height to avoid fee sniping, unless you have some specific reason to use a different
	 * locktime.
	 * 
	 * Returns `Err(())` if the output value is greater than the input value minus required fee,
	 * if a descriptor was duplicated, or if an output descriptor `script_pubkey`
	 * does not match the one we can spend.
	 * 
	 * We do not enforce that outputs meet the dust limit or that any output scripts are standard.
	 * 
	 * May panic if the [`SpendableOutputDescriptor`]s were not generated by channels which used
	 * this [`KeysManager`] or one of the [`InMemorySigner`] created by this [`KeysManager`].
	 */
	public Result_TransactionNoneZ spend_spendable_outputs(SpendableOutputDescriptor[] descriptors, TxOut[] outputs, byte[] change_destination_script, int feerate_sat_per_1000_weight, org.ldk.structs.Option_u32Z locktime) {
		long ret = bindings.KeysManager_spend_spendable_outputs(this.ptr, descriptors != null ? Arrays.stream(descriptors).mapToLong(descriptors_conv_27 -> descriptors_conv_27.ptr).toArray() : null, outputs != null ? Arrays.stream(outputs).mapToLong(outputs_conv_7 -> outputs_conv_7.ptr).toArray() : null, change_destination_script, feerate_sat_per_1000_weight, locktime.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(descriptors);
		Reference.reachabilityFence(outputs);
		Reference.reachabilityFence(change_destination_script);
		Reference.reachabilityFence(feerate_sat_per_1000_weight);
		Reference.reachabilityFence(locktime);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TransactionNoneZ ret_hu_conv = Result_TransactionNoneZ.constr_from_ptr(ret);
		for (SpendableOutputDescriptor descriptors_conv_27: descriptors) { if (this != null) { this.ptrs_to.add(descriptors_conv_27); }; };
		if (this != null) { this.ptrs_to.add(locktime); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new EntropySource which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned EntropySource must be freed before this_arg is
	 */
	public EntropySource as_EntropySource() {
		long ret = bindings.KeysManager_as_EntropySource(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		EntropySource ret_hu_conv = new EntropySource(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new NodeSigner which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned NodeSigner must be freed before this_arg is
	 */
	public NodeSigner as_NodeSigner() {
		long ret = bindings.KeysManager_as_NodeSigner(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		NodeSigner ret_hu_conv = new NodeSigner(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new SignerProvider which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned SignerProvider must be freed before this_arg is
	 */
	public SignerProvider as_SignerProvider() {
		long ret = bindings.KeysManager_as_SignerProvider(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		SignerProvider ret_hu_conv = new SignerProvider(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
