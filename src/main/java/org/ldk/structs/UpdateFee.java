package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;

public class UpdateFee extends CommonBase {
	UpdateFee(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		bindings.UpdateFee_free(ptr);
	}

	public UpdateFee(UpdateFee orig) {
		super(bindings.UpdateFee_clone(orig == null ? 0 : orig.ptr & ~1));
		this.ptrs_to.add(orig);
	}

	public byte[] get_channel_id(UpdateFee this_ptr) {
		byte[] ret = bindings.UpdateFee_get_channel_id(this_ptr == null ? 0 : this_ptr.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_channel_id(UpdateFee this_ptr, byte[] val) {
		bindings.UpdateFee_set_channel_id(this_ptr == null ? 0 : this_ptr.ptr & ~1, val);
		this.ptrs_to.add(this_ptr);
	}

	public int get_feerate_per_kw(UpdateFee this_ptr) {
		int ret = bindings.UpdateFee_get_feerate_per_kw(this_ptr == null ? 0 : this_ptr.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_feerate_per_kw(UpdateFee this_ptr, int val) {
		bindings.UpdateFee_set_feerate_per_kw(this_ptr == null ? 0 : this_ptr.ptr & ~1, val);
		this.ptrs_to.add(this_ptr);
	}

	public UpdateFee(byte[] channel_id_arg, int feerate_per_kw_arg) {
		super(bindings.UpdateFee_new(channel_id_arg, feerate_per_kw_arg));
	}

	public byte[] write(UpdateFee obj) {
		byte[] ret = bindings.UpdateFee_write(obj == null ? 0 : obj.ptr & ~1);
		this.ptrs_to.add(obj);
		return ret;
	}

	public UpdateFee(byte[] ser) {
		super(bindings.UpdateFee_read(ser));
	}

}