using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {

/**
 * An enum which can either contain a crate::c_types::ThirtyTwoBytes or not
 */
public class Option_PaymentSecretZ : CommonBase {
	protected Option_PaymentSecretZ(object _dummy, long ptr) : base(ptr) { }
	~Option_PaymentSecretZ() {
		if (ptr != 0) { bindings.COption_PaymentSecretZ_free(ptr); }
	}

	internal static Option_PaymentSecretZ constr_from_ptr(long ptr) {
		long raw_ty = bindings.LDKCOption_PaymentSecretZ_ty_from_ptr(ptr);
		switch (raw_ty) {
			case 0: return new Option_PaymentSecretZ_Some(ptr);
			case 1: return new Option_PaymentSecretZ_None(ptr);
			default:
				throw new ArgumentException("Impossible enum variant");
		}
	}

	/** A Option_PaymentSecretZ of type Some */
	public class Option_PaymentSecretZ_Some : Option_PaymentSecretZ {
		public byte[] some;
		internal Option_PaymentSecretZ_Some(long ptr) : base(null, ptr) {
			this.some = bindings.LDKCOption_PaymentSecretZ_Some_get_some(ptr);
		}
	}
	/** A Option_PaymentSecretZ of type None */
	public class Option_PaymentSecretZ_None : Option_PaymentSecretZ {
		internal Option_PaymentSecretZ_None(long ptr) : base(null, ptr) {
		}
	}
	/**
	 * Constructs a new COption_PaymentSecretZ containing a crate::c_types::ThirtyTwoBytes
	 */
	public static Option_PaymentSecretZ some(byte[] o) {
		long ret = bindings.COption_PaymentSecretZ_some(InternalUtils.check_arr_len(o, 32));
		GC.KeepAlive(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentSecretZ ret_hu_conv = org.ldk.structs.Option_PaymentSecretZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new COption_PaymentSecretZ containing nothing
	 */
	public static Option_PaymentSecretZ none() {
		long ret = bindings.COption_PaymentSecretZ_none();
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentSecretZ ret_hu_conv = org.ldk.structs.Option_PaymentSecretZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(ret_hu_conv); };
		return ret_hu_conv;
	}

	internal long clone_ptr() {
		long ret = bindings.COption_PaymentSecretZ_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a new COption_PaymentSecretZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Option_PaymentSecretZ clone() {
		long ret = bindings.COption_PaymentSecretZ_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_PaymentSecretZ ret_hu_conv = org.ldk.structs.Option_PaymentSecretZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

}
} } }
