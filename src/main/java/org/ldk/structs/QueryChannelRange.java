package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A [`query_channel_range`] message is used to query a peer for channel
 * UTXOs in a range of blocks. The recipient of a query makes a best
 * effort to reply to the query using one or more [`ReplyChannelRange`]
 * messages.
 * 
 * [`query_channel_range`]: https://github.com/lightning/bolts/blob/master/07-routing-gossip.md#the-query_channel_range-and-reply_channel_range-messages
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class QueryChannelRange extends CommonBase {
	QueryChannelRange(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.QueryChannelRange_free(ptr); }
	}

	/**
	 * The genesis hash of the blockchain being queried
	 */
	public byte[] get_chain_hash() {
		byte[] ret = bindings.QueryChannelRange_get_chain_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The genesis hash of the blockchain being queried
	 */
	public void set_chain_hash(byte[] val) {
		bindings.QueryChannelRange_set_chain_hash(this.ptr, InternalUtils.check_arr_len(val, 32));
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The height of the first block for the channel UTXOs being queried
	 */
	public int get_first_blocknum() {
		int ret = bindings.QueryChannelRange_get_first_blocknum(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The height of the first block for the channel UTXOs being queried
	 */
	public void set_first_blocknum(int val) {
		bindings.QueryChannelRange_set_first_blocknum(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * The number of blocks to include in the query results
	 */
	public int get_number_of_blocks() {
		int ret = bindings.QueryChannelRange_get_number_of_blocks(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * The number of blocks to include in the query results
	 */
	public void set_number_of_blocks(int val) {
		bindings.QueryChannelRange_set_number_of_blocks(this.ptr, val);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(val);
	}

	/**
	 * Constructs a new QueryChannelRange given each field
	 */
	public static QueryChannelRange of(byte[] chain_hash_arg, int first_blocknum_arg, int number_of_blocks_arg) {
		long ret = bindings.QueryChannelRange_new(InternalUtils.check_arr_len(chain_hash_arg, 32), first_blocknum_arg, number_of_blocks_arg);
		Reference.reachabilityFence(chain_hash_arg);
		Reference.reachabilityFence(first_blocknum_arg);
		Reference.reachabilityFence(number_of_blocks_arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.QueryChannelRange ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.QueryChannelRange(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	long clone_ptr() {
		long ret = bindings.QueryChannelRange_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the QueryChannelRange
	 */
	public QueryChannelRange clone() {
		long ret = bindings.QueryChannelRange_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.QueryChannelRange ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.QueryChannelRange(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Generates a non-cryptographic 64-bit hash of the QueryChannelRange.
	 */
	public long hash() {
		long ret = bindings.QueryChannelRange_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Checks if two QueryChannelRanges contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 * Two objects with NULL inner values will be considered "equal" here.
	 */
	public boolean eq(org.ldk.structs.QueryChannelRange b) {
		boolean ret = bindings.QueryChannelRange_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		if (this != null) { this.ptrs_to.add(b); };
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof QueryChannelRange)) return false;
		return this.eq((QueryChannelRange)o);
	}
	/**
	 * Calculates the overflow safe ending block height for the query.
	 * 
	 * Overflow returns `0xffffffff`, otherwise returns `first_blocknum + number_of_blocks`.
	 */
	public int end_blocknum() {
		int ret = bindings.QueryChannelRange_end_blocknum(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Serialize the QueryChannelRange object into a byte array which can be read by QueryChannelRange_read
	 */
	public byte[] write() {
		byte[] ret = bindings.QueryChannelRange_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a QueryChannelRange from a byte array, created by QueryChannelRange_write
	 */
	public static Result_QueryChannelRangeDecodeErrorZ read(byte[] ser) {
		long ret = bindings.QueryChannelRange_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_QueryChannelRangeDecodeErrorZ ret_hu_conv = Result_QueryChannelRangeDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
