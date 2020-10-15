package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;

public class NodeInfo extends CommonBase {
	NodeInfo(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		bindings.NodeInfo_free(ptr);
	}

	// Skipped NodeInfo_set_channels
	public RoutingFees get_lowest_inbound_channel_fees(NodeInfo this_ptr) {
		RoutingFees ret = new RoutingFees(null, bindings.NodeInfo_get_lowest_inbound_channel_fees(this_ptr == null ? 0 : this_ptr.ptr & ~1));
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	public void set_lowest_inbound_channel_fees(NodeInfo this_ptr, RoutingFees val) {
		bindings.NodeInfo_set_lowest_inbound_channel_fees(this_ptr == null ? 0 : this_ptr.ptr & ~1, val == null ? 0 : val.ptr & ~1);
		this.ptrs_to.add(this_ptr);
		this.ptrs_to.add(val);
	}

	public NodeAnnouncementInfo get_announcement_info(NodeInfo this_ptr) {
		NodeAnnouncementInfo ret = new NodeAnnouncementInfo(null, bindings.NodeInfo_get_announcement_info(this_ptr == null ? 0 : this_ptr.ptr & ~1));
		this.ptrs_to.add(this_ptr);
		return ret;
	}

	// Skipped NodeInfo_set_announcement_info
	// Skipped NodeInfo_new
	public byte[] write(NodeInfo obj) {
		byte[] ret = bindings.NodeInfo_write(obj == null ? 0 : obj.ptr & ~1);
		this.ptrs_to.add(obj);
		return ret;
	}

	public NodeInfo(byte[] ser) {
		super(bindings.NodeInfo_read(ser));
	}

}