package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * [`ScoreLookUp`] implementation that uses a fixed penalty.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class FixedPenaltyScorer extends CommonBase {
	FixedPenaltyScorer(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.FixedPenaltyScorer_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.FixedPenaltyScorer_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the FixedPenaltyScorer
	 */
	public FixedPenaltyScorer clone() {
		long ret = bindings.FixedPenaltyScorer_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FixedPenaltyScorer ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FixedPenaltyScorer(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new scorer using `penalty_msat`.
	 */
	public static FixedPenaltyScorer with_penalty(long penalty_msat) {
		long ret = bindings.FixedPenaltyScorer_with_penalty(penalty_msat);
		Reference.reachabilityFence(penalty_msat);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FixedPenaltyScorer ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FixedPenaltyScorer(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new ScoreLookUp which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned ScoreLookUp must be freed before this_arg is
	 */
	public ScoreLookUp as_ScoreLookUp() {
		long ret = bindings.FixedPenaltyScorer_as_ScoreLookUp(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ScoreLookUp ret_hu_conv = new ScoreLookUp(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Constructs a new ScoreUpdate which calls the relevant methods on this_arg.
	 * This copies the `inner` pointer in this_arg and thus the returned ScoreUpdate must be freed before this_arg is
	 */
	public ScoreUpdate as_ScoreUpdate() {
		long ret = bindings.FixedPenaltyScorer_as_ScoreUpdate(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		ScoreUpdate ret_hu_conv = new ScoreUpdate(null, ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Serialize the FixedPenaltyScorer object into a byte array which can be read by FixedPenaltyScorer_read
	 */
	public byte[] write() {
		byte[] ret = bindings.FixedPenaltyScorer_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a FixedPenaltyScorer from a byte array, created by FixedPenaltyScorer_write
	 */
	public static Result_FixedPenaltyScorerDecodeErrorZ read(byte[] ser, long arg) {
		long ret = bindings.FixedPenaltyScorer_read(ser, arg);
		Reference.reachabilityFence(ser);
		Reference.reachabilityFence(arg);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_FixedPenaltyScorerDecodeErrorZ ret_hu_conv = Result_FixedPenaltyScorerDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
