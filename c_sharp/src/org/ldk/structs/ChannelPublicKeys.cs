using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * One counterparty's public keys which do not change over the life of a channel.
 */
public class ChannelPublicKeys : CommonBase {
	internal ChannelPublicKeys(object _dummy, long ptr) : base(ptr) { }
	~ChannelPublicKeys() {
		if (ptr != 0) { bindings.ChannelPublicKeys_free(ptr); }
	}

	/**
	 * The public key which is used to sign all commitment transactions, as it appears in the
	 * on-chain channel lock-in 2-of-2 multisig output.
	 */
	public byte[] get_funding_pubkey() {
		long ret = bindings.ChannelPublicKeys_get_funding_pubkey(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The public key which is used to sign all commitment transactions, as it appears in the
	 * on-chain channel lock-in 2-of-2 multisig output.
	 */
	public void set_funding_pubkey(byte[] val) {
		bindings.ChannelPublicKeys_set_funding_pubkey(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The base point which is used (with derive_public_revocation_key) to derive per-commitment
	 * revocation keys. This is combined with the per-commitment-secret generated by the
	 * counterparty to create a secret which the counterparty can reveal to revoke previous
	 * states.
	 */
	public byte[] get_revocation_basepoint() {
		long ret = bindings.ChannelPublicKeys_get_revocation_basepoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The base point which is used (with derive_public_revocation_key) to derive per-commitment
	 * revocation keys. This is combined with the per-commitment-secret generated by the
	 * counterparty to create a secret which the counterparty can reveal to revoke previous
	 * states.
	 */
	public void set_revocation_basepoint(byte[] val) {
		bindings.ChannelPublicKeys_set_revocation_basepoint(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The public key on which the non-broadcaster (ie the countersignatory) receives an immediately
	 * spendable primary channel balance on the broadcaster's commitment transaction. This key is
	 * static across every commitment transaction.
	 */
	public byte[] get_payment_point() {
		long ret = bindings.ChannelPublicKeys_get_payment_point(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The public key on which the non-broadcaster (ie the countersignatory) receives an immediately
	 * spendable primary channel balance on the broadcaster's commitment transaction. This key is
	 * static across every commitment transaction.
	 */
	public void set_payment_point(byte[] val) {
		bindings.ChannelPublicKeys_set_payment_point(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The base point which is used (with derive_public_key) to derive a per-commitment payment
	 * public key which receives non-HTLC-encumbered funds which are only available for spending
	 * after some delay (or can be claimed via the revocation path).
	 */
	public byte[] get_delayed_payment_basepoint() {
		long ret = bindings.ChannelPublicKeys_get_delayed_payment_basepoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The base point which is used (with derive_public_key) to derive a per-commitment payment
	 * public key which receives non-HTLC-encumbered funds which are only available for spending
	 * after some delay (or can be claimed via the revocation path).
	 */
	public void set_delayed_payment_basepoint(byte[] val) {
		bindings.ChannelPublicKeys_set_delayed_payment_basepoint(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * The base point which is used (with derive_public_key) to derive a per-commitment public key
	 * which is used to encumber HTLC-in-flight outputs.
	 */
	public byte[] get_htlc_basepoint() {
		long ret = bindings.ChannelPublicKeys_get_htlc_basepoint(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * The base point which is used (with derive_public_key) to derive a per-commitment public key
	 * which is used to encumber HTLC-in-flight outputs.
	 */
	public void set_htlc_basepoint(byte[] val) {
		bindings.ChannelPublicKeys_set_htlc_basepoint(this.ptr, InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(val, 33)));
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	/**
	 * Constructs a new ChannelPublicKeys given each field
	 */
	public static ChannelPublicKeys of(byte[] funding_pubkey_arg, byte[] revocation_basepoint_arg, byte[] payment_point_arg, byte[] delayed_payment_basepoint_arg, byte[] htlc_basepoint_arg) {
		long ret = bindings.ChannelPublicKeys_new(InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(funding_pubkey_arg, 33)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(revocation_basepoint_arg, 33)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(payment_point_arg, 33)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(delayed_payment_basepoint_arg, 33)), InternalUtils.encodeUint8Array(InternalUtils.check_arr_len(htlc_basepoint_arg, 33)));
		GC.KeepAlive(funding_pubkey_arg);
		GC.KeepAlive(revocation_basepoint_arg);
		GC.KeepAlive(payment_point_arg);
		GC.KeepAlive(delayed_payment_basepoint_arg);
		GC.KeepAlive(htlc_basepoint_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelPublicKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelPublicKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.ChannelPublicKeys_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelPublicKeys
	 */
	public ChannelPublicKeys clone() {
		long ret = bindings.ChannelPublicKeys_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelPublicKeys ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelPublicKeys(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the ChannelPublicKeys.
	 */
	public long hash() {
		long ret = bindings.ChannelPublicKeys_hash(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	public override int GetHashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two ChannelPublicKeyss contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelPublicKeys b) {
		bool ret = bindings.ChannelPublicKeys_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelPublicKeys)) return false;
		return this.eq((ChannelPublicKeys)o);
	}
	/**
	 * Serialize the ChannelPublicKeys object into a byte array which can be read by ChannelPublicKeys_read
	 */
	public byte[] write() {
		long ret = bindings.ChannelPublicKeys_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelPublicKeys from a byte array, created by ChannelPublicKeys_write
	 */
	public static Result_ChannelPublicKeysDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelPublicKeys_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelPublicKeysDecodeErrorZ ret_hu_conv = Result_ChannelPublicKeysDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }