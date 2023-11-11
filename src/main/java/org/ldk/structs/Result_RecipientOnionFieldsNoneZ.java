package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_RecipientOnionFieldsNoneZ extends CommonBase {
	private Result_RecipientOnionFieldsNoneZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_RecipientOnionFieldsNoneZ_free(ptr); } super.finalize();
	}

	static Result_RecipientOnionFieldsNoneZ constr_from_ptr(long ptr) {
		if (bindings.CResult_RecipientOnionFieldsNoneZ_is_ok(ptr)) {
			return new Result_RecipientOnionFieldsNoneZ_OK(null, ptr);
		} else {
			return new Result_RecipientOnionFieldsNoneZ_Err(null, ptr);
		}
	}
	public static final class Result_RecipientOnionFieldsNoneZ_OK extends Result_RecipientOnionFieldsNoneZ {
		public final RecipientOnionFields res;
		private Result_RecipientOnionFieldsNoneZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_RecipientOnionFieldsNoneZ_get_ok(ptr);
			org.ldk.structs.RecipientOnionFields res_hu_conv = null; if (res < 0 || res > 4096) { res_hu_conv = new org.ldk.structs.RecipientOnionFields(null, res); }
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_RecipientOnionFieldsNoneZ_Err extends Result_RecipientOnionFieldsNoneZ {
		private Result_RecipientOnionFieldsNoneZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	/**
	 * Creates a new CResult_RecipientOnionFieldsNoneZ in the success state.
	 */
	public static Result_RecipientOnionFieldsNoneZ ok(org.ldk.structs.RecipientOnionFields o) {
		long ret = bindings.CResult_RecipientOnionFieldsNoneZ_ok(o == null ? 0 : o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecipientOnionFieldsNoneZ ret_hu_conv = Result_RecipientOnionFieldsNoneZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_RecipientOnionFieldsNoneZ in the error state.
	 */
	public static Result_RecipientOnionFieldsNoneZ err() {
		long ret = bindings.CResult_RecipientOnionFieldsNoneZ_err();
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecipientOnionFieldsNoneZ ret_hu_conv = Result_RecipientOnionFieldsNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_RecipientOnionFieldsNoneZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_RecipientOnionFieldsNoneZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_RecipientOnionFieldsNoneZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_RecipientOnionFieldsNoneZ clone() {
		long ret = bindings.CResult_RecipientOnionFieldsNoneZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RecipientOnionFieldsNoneZ ret_hu_conv = Result_RecipientOnionFieldsNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}