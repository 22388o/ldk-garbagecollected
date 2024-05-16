package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * The set of public keys which are used in the creation of one commitment transaction.
 * These are derived from the channel base keys and per-commitment data.
 * 
 * A broadcaster key is provided from potential broadcaster of the computed transaction.
 * A countersignatory key is coming from a protocol participant unable to broadcast the
 * transaction.
 * 
 * These keys are assumed to be good, either because the code derived them from
 * channel basepoints via the new function, or they were obtained via
 * CommitmentTransaction.trust().keys() because we trusted the source of the
 * pre-calculated keys.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class TxCreationKeys extends CommonBase {
	TxCreationKeys(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.TxCreationKeys_free(ptr); }
	}

	/**
	 * The broadcaster's per-commitment public key which was used to derive the other keys.
	 */
	public byte[] get_per_commitment_point() {
		byte[] ret = bindings.TxCreationKeys_get_per_commitment_point(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The broadcaster's per-commitment public key which was used to derive the other keys.
	 */
	public void set_per_commitment_point(byte[] val) {
		bindings.TxCreationKeys_set_per_commitment_point(this.ptr, InternalUtils.check_arr_len(val, 33));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The revocation key which is used to allow the broadcaster of the commitment
	 * transaction to provide their counterparty the ability to punish them if they broadcast
	 * an old state.
	 */
	public RevocationKey get_revocation_key() {
		long ret = bindings.TxCreationKeys_get_revocation_key(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RevocationKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RevocationKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * The revocation key which is used to allow the broadcaster of the commitment
	 * transaction to provide their counterparty the ability to punish them if they broadcast
	 * an old state.
	 */
	public void set_revocation_key(org.ldk.structs.RevocationKey val) {
		bindings.TxCreationKeys_set_revocation_key(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
		if (this != null) { this.ptrs_to.add(val); };
	}

	/**
	 * Broadcaster's HTLC Key
	 */
	public HtlcKey get_broadcaster_htlc_key() {
		long ret = bindings.TxCreationKeys_get_broadcaster_htlc_key(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HtlcKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HtlcKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Broadcaster's HTLC Key
	 */
	public void set_broadcaster_htlc_key(org.ldk.structs.HtlcKey val) {
		bindings.TxCreationKeys_set_broadcaster_htlc_key(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
		if (this != null) { this.ptrs_to.add(val); };
	}

	/**
	 * Countersignatory's HTLC Key
	 */
	public HtlcKey get_countersignatory_htlc_key() {
		long ret = bindings.TxCreationKeys_get_countersignatory_htlc_key(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.HtlcKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.HtlcKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Countersignatory's HTLC Key
	 */
	public void set_countersignatory_htlc_key(org.ldk.structs.HtlcKey val) {
		bindings.TxCreationKeys_set_countersignatory_htlc_key(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
		if (this != null) { this.ptrs_to.add(val); };
	}

	/**
	 * Broadcaster's Payment Key (which isn't allowed to be spent from for some delay)
	 */
	public DelayedPaymentKey get_broadcaster_delayed_payment_key() {
		long ret = bindings.TxCreationKeys_get_broadcaster_delayed_payment_key(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.DelayedPaymentKey ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.DelayedPaymentKey(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Broadcaster's Payment Key (which isn't allowed to be spent from for some delay)
	 */
	public void set_broadcaster_delayed_payment_key(org.ldk.structs.DelayedPaymentKey val) {
		bindings.TxCreationKeys_set_broadcaster_delayed_payment_key(this.ptr, val.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
		if (this != null) { this.ptrs_to.add(val); };
	}

	/**
	 * Constructs a new TxCreationKeys given each field
	 */
	public static TxCreationKeys of(byte[] per_commitment_point_arg, org.ldk.structs.RevocationKey revocation_key_arg, org.ldk.structs.HtlcKey broadcaster_htlc_key_arg, org.ldk.structs.HtlcKey countersignatory_htlc_key_arg, org.ldk.structs.DelayedPaymentKey broadcaster_delayed_payment_key_arg) {
		long ret = bindings.TxCreationKeys_new(InternalUtils.check_arr_len(per_commitment_point_arg, 33), revocation_key_arg.ptr, broadcaster_htlc_key_arg.ptr, countersignatory_htlc_key_arg.ptr, broadcaster_delayed_payment_key_arg.ptr);
		Reference.reachabilityFence(per_commitment_point_arg);
		Reference.reachabilityFence(revocation_key_arg);
		Reference.reachabilityFence(broadcaster_htlc_key_arg);
		Reference.reachabilityFence(countersignatory_htlc_key_arg);
		Reference.reachabilityFence(broadcaster_delayed_payment_key_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxCreationKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxCreationKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(revocation_key_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(broadcaster_htlc_key_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(countersignatory_htlc_key_arg); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(broadcaster_delayed_payment_key_arg); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two TxCreationKeyss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.TxCreationKeys b) {
		boolean ret = bindings.TxCreationKeys_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof TxCreationKeys)) return false;
		return this.eq((TxCreationKeys)o);
	}
	long clone_ptr() {
		long ret = bindings.TxCreationKeys_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the TxCreationKeys
	 */
	public TxCreationKeys clone() {
		long ret = bindings.TxCreationKeys_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxCreationKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxCreationKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the TxCreationKeys object into a byte array which can be read by TxCreationKeys_read
	 */
	public byte[] write() {
		byte[] ret = bindings.TxCreationKeys_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a TxCreationKeys from a byte array, created by TxCreationKeys_write
	 */
	public static Result_TxCreationKeysDecodeErrorZ read(byte[] ser) {
		long ret = bindings.TxCreationKeys_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_TxCreationKeysDecodeErrorZ ret_hu_conv = Result_TxCreationKeysDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Create per-state keys from channel base points and the per-commitment point.
	 * Key set is asymmetric and can't be used as part of counter-signatory set of transactions.
	 */
	public static TxCreationKeys derive_new(byte[] per_commitment_point, org.ldk.structs.DelayedPaymentBasepoint broadcaster_delayed_payment_base, org.ldk.structs.HtlcBasepoint broadcaster_htlc_base, org.ldk.structs.RevocationBasepoint countersignatory_revocation_base, org.ldk.structs.HtlcBasepoint countersignatory_htlc_base) {
		long ret = bindings.TxCreationKeys_derive_new(InternalUtils.check_arr_len(per_commitment_point, 33), broadcaster_delayed_payment_base.ptr, broadcaster_htlc_base.ptr, countersignatory_revocation_base.ptr, countersignatory_htlc_base.ptr);
		Reference.reachabilityFence(per_commitment_point);
		Reference.reachabilityFence(broadcaster_delayed_payment_base);
		Reference.reachabilityFence(broadcaster_htlc_base);
		Reference.reachabilityFence(countersignatory_revocation_base);
		Reference.reachabilityFence(countersignatory_htlc_base);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxCreationKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxCreationKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(broadcaster_delayed_payment_base); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(broadcaster_htlc_base); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(countersignatory_revocation_base); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(countersignatory_htlc_base); };
		return ret_hu_conv;
	}

	/**
	 * Generate per-state keys from channel static keys.
	 * Key set is asymmetric and can't be used as part of counter-signatory set of transactions.
	 */
	public static TxCreationKeys from_channel_static_keys(byte[] per_commitment_point, org.ldk.structs.ChannelPublicKeys broadcaster_keys, org.ldk.structs.ChannelPublicKeys countersignatory_keys) {
		long ret = bindings.TxCreationKeys_from_channel_static_keys(InternalUtils.check_arr_len(per_commitment_point, 33), broadcaster_keys.ptr, countersignatory_keys.ptr);
		Reference.reachabilityFence(per_commitment_point);
		Reference.reachabilityFence(broadcaster_keys);
		Reference.reachabilityFence(countersignatory_keys);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.TxCreationKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.TxCreationKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(broadcaster_keys); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(countersignatory_keys); };
		return ret_hu_conv;
	}

}
