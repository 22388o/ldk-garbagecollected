using org.ldk.impl;
using org.ldk.enums;
using org.ldk.util;
using System;

namespace org { namespace ldk { namespace structs {


/**
 * An update generated by the underlying channel itself which contains some new information the
 * [`ChannelMonitor`] should be made aware of.
 * 
 * Because this represents only a small number of updates to the underlying state, it is generally
 * much smaller than a full [`ChannelMonitor`]. However, for large single commitment transaction
 * updates (e.g. ones during which there are hundreds of HTLCs pending on the commitment
 * transaction), a single update may reach upwards of 1 MiB in serialized size.
 */
public class ChannelMonitorUpdate : CommonBase {
	internal ChannelMonitorUpdate(object _dummy, long ptr) : base(ptr) { }
	~ChannelMonitorUpdate() {
		if (ptr != 0) { bindings.ChannelMonitorUpdate_free(ptr); }
	}

	/**
	 * The sequence number of this update. Updates *must* be replayed in-order according to this
	 * sequence number (and updates may panic if they are not). The update_id values are strictly
	 * increasing and increase by one for each new update, with two exceptions specified below.
	 * 
	 * This sequence number is also used to track up to which points updates which returned
	 * [`ChannelMonitorUpdateStatus::InProgress`] have been applied to all copies of a given
	 * ChannelMonitor when ChannelManager::channel_monitor_updated is called.
	 * 
	 * The only instances we allow where update_id values are not strictly increasing have a
	 * special update ID of [`CLOSED_CHANNEL_UPDATE_ID`]. This update ID is used for updates that
	 * will force close the channel by broadcasting the latest commitment transaction or
	 * special post-force-close updates, like providing preimages necessary to claim outputs on the
	 * broadcast commitment transaction. See its docs for more details.
	 * 
	 * [`ChannelMonitorUpdateStatus::InProgress`]: super::ChannelMonitorUpdateStatus::InProgress
	 */
	public long get_update_id() {
		long ret = bindings.ChannelMonitorUpdate_get_update_id(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * The sequence number of this update. Updates *must* be replayed in-order according to this
	 * sequence number (and updates may panic if they are not). The update_id values are strictly
	 * increasing and increase by one for each new update, with two exceptions specified below.
	 * 
	 * This sequence number is also used to track up to which points updates which returned
	 * [`ChannelMonitorUpdateStatus::InProgress`] have been applied to all copies of a given
	 * ChannelMonitor when ChannelManager::channel_monitor_updated is called.
	 * 
	 * The only instances we allow where update_id values are not strictly increasing have a
	 * special update ID of [`CLOSED_CHANNEL_UPDATE_ID`]. This update ID is used for updates that
	 * will force close the channel by broadcasting the latest commitment transaction or
	 * special post-force-close updates, like providing preimages necessary to claim outputs on the
	 * broadcast commitment transaction. See its docs for more details.
	 * 
	 * [`ChannelMonitorUpdateStatus::InProgress`]: super::ChannelMonitorUpdateStatus::InProgress
	 */
	public void set_update_id(long val) {
		bindings.ChannelMonitorUpdate_set_update_id(this.ptr, val);
		GC.KeepAlive(this);
		GC.KeepAlive(val);
	}

	internal long clone_ptr() {
		long ret = bindings.ChannelMonitorUpdate_clone_ptr(this.ptr);
		GC.KeepAlive(this);
		return ret;
	}

	/**
	 * Creates a copy of the ChannelMonitorUpdate
	 */
	public ChannelMonitorUpdate clone() {
		long ret = bindings.ChannelMonitorUpdate_clone(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.ChannelMonitorUpdate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.ChannelMonitorUpdate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.AddLast(this); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two ChannelMonitorUpdates contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public bool eq(org.ldk.structs.ChannelMonitorUpdate b) {
		bool ret = bindings.ChannelMonitorUpdate_eq(this.ptr, b == null ? 0 : b.ptr);
		GC.KeepAlive(this);
		GC.KeepAlive(b);
		if (this != null) { this.ptrs_to.AddLast(b); };
		return ret;
	}

	public override bool Equals(object o) {
		if (!(o is ChannelMonitorUpdate)) return false;
		return this.eq((ChannelMonitorUpdate)o);
	}
	/**
	 * Serialize the ChannelMonitorUpdate object into a byte array which can be read by ChannelMonitorUpdate_read
	 */
	public byte[] write() {
		long ret = bindings.ChannelMonitorUpdate_write(this.ptr);
		GC.KeepAlive(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		byte[] ret_conv = InternalUtils.decodeUint8Array(ret);
		return ret_conv;
	}

	/**
	 * Read a ChannelMonitorUpdate from a byte array, created by ChannelMonitorUpdate_write
	 */
	public static Result_ChannelMonitorUpdateDecodeErrorZ read(byte[] ser) {
		long ret = bindings.ChannelMonitorUpdate_read(InternalUtils.encodeUint8Array(ser));
		GC.KeepAlive(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_ChannelMonitorUpdateDecodeErrorZ ret_hu_conv = Result_ChannelMonitorUpdateDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
} } }
