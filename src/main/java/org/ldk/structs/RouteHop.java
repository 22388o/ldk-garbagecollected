package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;

public class RouteHop extends CommonBase {
	RouteHop(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		bindings.RouteHop_free(ptr);
	}

	public RouteHop(RouteHop orig) {
		super(bindings.RouteHop_clone(orig == null ? 0 : orig.ptr & ~1));
		this.ptrs_to.add(orig);
	}

	public byte[] get_pubkey(RouteHop this_ptr) {
		byte[] ret = bindings.RouteHop_get_pubkey(this_ptr == null ? 0 : this_ptr.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_pubkey(RouteHop this_ptr, byte[] val) {
		bindings.RouteHop_set_pubkey(this_ptr == null ? 0 : this_ptr.ptr & ~1, val);
		this.ptrs_to.add(this_ptr);
	}

	public NodeFeatures get_node_features(RouteHop this_ptr) {
		NodeFeatures ret = new NodeFeatures(null, bindings.RouteHop_get_node_features(this_ptr == null ? 0 : this_ptr.ptr & ~1));
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	// Skipped RouteHop_set_node_features
	public long get_short_channel_id(RouteHop this_ptr) {
		long ret = bindings.RouteHop_get_short_channel_id(this_ptr == null ? 0 : this_ptr.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_short_channel_id(RouteHop this_ptr, long val) {
		bindings.RouteHop_set_short_channel_id(this_ptr == null ? 0 : this_ptr.ptr & ~1, val);
		this.ptrs_to.add(this_ptr);
	}

	public ChannelFeatures get_channel_features(RouteHop this_ptr) {
		ChannelFeatures ret = new ChannelFeatures(null, bindings.RouteHop_get_channel_features(this_ptr == null ? 0 : this_ptr.ptr & ~1));
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	// Skipped RouteHop_set_channel_features
	public long get_fee_msat(RouteHop this_ptr) {
		long ret = bindings.RouteHop_get_fee_msat(this_ptr == null ? 0 : this_ptr.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_fee_msat(RouteHop this_ptr, long val) {
		bindings.RouteHop_set_fee_msat(this_ptr == null ? 0 : this_ptr.ptr & ~1, val);
		this.ptrs_to.add(this_ptr);
	}

	public int get_cltv_expiry_delta(RouteHop this_ptr) {
		int ret = bindings.RouteHop_get_cltv_expiry_delta(this_ptr == null ? 0 : this_ptr.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_cltv_expiry_delta(RouteHop this_ptr, int val) {
		bindings.RouteHop_set_cltv_expiry_delta(this_ptr == null ? 0 : this_ptr.ptr & ~1, val);
		this.ptrs_to.add(this_ptr);
	}

	// Skipped RouteHop_new
}