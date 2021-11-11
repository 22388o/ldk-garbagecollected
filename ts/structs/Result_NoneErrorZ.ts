
import CommonBase from './CommonBase';
import * as bindings from '../bindings' // TODO: figure out location

public class Result_NoneErrorZ extends CommonBase {
	private Result_NoneErrorZ(Object _dummy, long ptr) { super(ptr); }
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CResult_NoneErrorZ_free(ptr); } super.finalize();
	}

	static Result_NoneErrorZ constr_from_ptr(long ptr) {
		if (bindings.CResult_NoneErrorZ_is_ok(ptr)) {
			return new Result_NoneErrorZ_OK(null, ptr);
		} else {
			return new Result_NoneErrorZ_Err(null, ptr);
		}
	}
	public static final class Result_NoneErrorZ_OK extends Result_NoneErrorZ {
		private Result_NoneErrorZ_OK(Object _dummy, long ptr) {
			super(_dummy, ptr);
		}
	}

	public static final class Result_NoneErrorZ_Err extends Result_NoneErrorZ {
		public final IOError err;
		private Result_NoneErrorZ_Err(Object _dummy, long ptr) {
			super(_dummy, ptr);
			this.err = bindings.LDKCResult_NoneErrorZ_get_err(ptr);
		}
	}

	public static Result_NoneErrorZ constructor_ok() {
		number ret = bindings.CResult_NoneErrorZ_ok();
		Result_NoneErrorZ ret_hu_conv = Result_NoneErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	public static Result_NoneErrorZ constructor_err(IOError e) {
		number ret = bindings.CResult_NoneErrorZ_err(e);
		Result_NoneErrorZ ret_hu_conv = Result_NoneErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	public boolean is_ok() {
		boolean ret = bindings.CResult_NoneErrorZ_is_ok(this.ptr);
		return ret;
	}

	public number clone_ptr() {
		number ret = bindings.CResult_NoneErrorZ_clone_ptr(this.ptr);
		return ret;
	}

	public Result_NoneErrorZ clone() {
		number ret = bindings.CResult_NoneErrorZ_clone(this.ptr);
		Result_NoneErrorZ ret_hu_conv = Result_NoneErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
