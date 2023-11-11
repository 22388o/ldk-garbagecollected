package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

public class Result_MaxDustHTLCExposureDecodeErrorZ extends CommonBase {
	private Result_MaxDustHTLCExposureDecodeErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_free(ptr); } super.finalize();
	}

	static Result_MaxDustHTLCExposureDecodeErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_is_ok(ptr)) {
			return new Result_MaxDustHTLCExposureDecodeErrorZ_OK(null, ptr);
		} else {
			return new Result_MaxDustHTLCExposureDecodeErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_MaxDustHTLCExposureDecodeErrorZ_OK extends Result_MaxDustHTLCExposureDecodeErrorZ {
		public final MaxDustHTLCExposure res;
		private Result_MaxDustHTLCExposureDecodeErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long res = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_get_ok(ptr);
			org.ldk.structs.MaxDustHTLCExposure res_hu_conv = org.ldk.structs.MaxDustHTLCExposure.constr_from_ptr(res);
			if (res_hu_conv != null) { res_hu_conv.ptrs_to.add(this); };
			this.res = res_hu_conv;
		}
	}

	public static final class Result_MaxDustHTLCExposureDecodeErrorZ_Err extends Result_MaxDustHTLCExposureDecodeErrorZ {
		public final DecodeError err;
		private Result_MaxDustHTLCExposureDecodeErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			long err = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_get_err(ptr);
			org.ldk.structs.DecodeError err_hu_conv = org.ldk.structs.DecodeError.constr_from_ptr(err);
			if (err_hu_conv != null) { err_hu_conv.ptrs_to.add(this); };
			this.err = err_hu_conv;
		}
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ in the success state.
	 */
	public static Result_MaxDustHTLCExposureDecodeErrorZ ok(org.ldk.structs.MaxDustHTLCExposure o) {
		long ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_ok(o.ptr);
		Reference.reachabilityFence(o);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(o); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ in the error state.
	 */
	public static Result_MaxDustHTLCExposureDecodeErrorZ err(org.ldk.structs.DecodeError e) {
		long ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_err(e.ptr);
		Reference.reachabilityFence(e);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(e); };
		return ret_hu_conv;
	}

	/**
	 * Checks if the given object is currently in the success state
	 */
	public boolean is_ok() {
		boolean ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_is_ok(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	long clone_ptr() {
		long ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a new CResult_MaxDustHTLCExposureDecodeErrorZ which has the same data as `orig`
	 * but with all dynamically-allocated buffers duplicated in new buffers.
	 */
	public Result_MaxDustHTLCExposureDecodeErrorZ clone() {
		long ret = bindings.CResult_MaxDustHTLCExposureDecodeErrorZ_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_MaxDustHTLCExposureDecodeErrorZ ret_hu_conv = Result_MaxDustHTLCExposureDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}