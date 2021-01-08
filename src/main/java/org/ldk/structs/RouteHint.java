package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;

@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class RouteHint extends CommonBase {
	RouteHint(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.RouteHint_free(ptr); }
	}

	public RouteHint clone() {
		long ret = bindings.RouteHint_clone(this.ptr);
		RouteHint ret_hu_conv = new RouteHint(null, ret);
		return ret_hu_conv;
	}

	public byte[] get_src_node_id() {
		byte[] ret = bindings.RouteHint_get_src_node_id(this.ptr);
		return ret;
	}

	public void set_src_node_id(byte[] val) {
		bindings.RouteHint_set_src_node_id(this.ptr, val);
	}

	public long get_short_channel_id() {
		long ret = bindings.RouteHint_get_short_channel_id(this.ptr);
		return ret;
	}

	public void set_short_channel_id(long val) {
		bindings.RouteHint_set_short_channel_id(this.ptr, val);
	}

	public RoutingFees get_fees() {
		long ret = bindings.RouteHint_get_fees(this.ptr);
		RoutingFees ret_hu_conv = new RoutingFees(null, ret);
		return ret_hu_conv;
	}

	public void set_fees(RoutingFees val) {
		bindings.RouteHint_set_fees(this.ptr, val == null ? 0 : val.ptr & ~1);
		this.ptrs_to.add(val);
	}

	public short get_cltv_expiry_delta() {
		short ret = bindings.RouteHint_get_cltv_expiry_delta(this.ptr);
		return ret;
	}

	public void set_cltv_expiry_delta(short val) {
		bindings.RouteHint_set_cltv_expiry_delta(this.ptr, val);
	}

	public long get_htlc_minimum_msat() {
		long ret = bindings.RouteHint_get_htlc_minimum_msat(this.ptr);
		return ret;
	}

	public void set_htlc_minimum_msat(long val) {
		bindings.RouteHint_set_htlc_minimum_msat(this.ptr, val);
	}

	public static RouteHint constructor_new(byte[] src_node_id_arg, long short_channel_id_arg, RoutingFees fees_arg, short cltv_expiry_delta_arg, long htlc_minimum_msat_arg) {
		long ret = bindings.RouteHint_new(src_node_id_arg, short_channel_id_arg, fees_arg == null ? 0 : fees_arg.ptr & ~1, cltv_expiry_delta_arg, htlc_minimum_msat_arg);
		RouteHint ret_hu_conv = new RouteHint(null, ret);
		ret_hu_conv.ptrs_to.add(fees_arg);
		return ret_hu_conv;
	}

}
