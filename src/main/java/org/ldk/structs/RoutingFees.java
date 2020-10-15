package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;

public class RoutingFees extends CommonBase {
	RoutingFees(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		bindings.RoutingFees_free(ptr);
	}

	public RoutingFees(RoutingFees orig) {
		super(bindings.RoutingFees_clone(orig == null ? 0 : orig.ptr & ~1));
		this.ptrs_to.add(orig);
	}

	public int get_base_msat(RoutingFees this_ptr) {
		int ret = bindings.RoutingFees_get_base_msat(this_ptr == null ? 0 : this_ptr.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_base_msat(RoutingFees this_ptr, int val) {
		bindings.RoutingFees_set_base_msat(this_ptr == null ? 0 : this_ptr.ptr & ~1, val);
		this.ptrs_to.add(this_ptr);
	}

	public int get_proportional_millionths(RoutingFees this_ptr) {
		int ret = bindings.RoutingFees_get_proportional_millionths(this_ptr == null ? 0 : this_ptr.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_proportional_millionths(RoutingFees this_ptr, int val) {
		bindings.RoutingFees_set_proportional_millionths(this_ptr == null ? 0 : this_ptr.ptr & ~1, val);
		this.ptrs_to.add(this_ptr);
	}

	public RoutingFees(int base_msat_arg, int proportional_millionths_arg) {
		super(bindings.RoutingFees_new(base_msat_arg, proportional_millionths_arg));
	}

	public RoutingFees(byte[] ser) {
		super(bindings.RoutingFees_read(ser));
	}

	public byte[] write(RoutingFees obj) {
		byte[] ret = bindings.RoutingFees_write(obj == null ? 0 : obj.ptr & ~1);
		this.ptrs_to.add(obj);
		return ret;
	}

}