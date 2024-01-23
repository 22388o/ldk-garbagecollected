package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * A [`CandidateRouteHop::FirstHop`] entry.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class FirstHopCandidate extends CommonBase {
	FirstHopCandidate(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.FirstHopCandidate_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.FirstHopCandidate_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the FirstHopCandidate
	 */
	public FirstHopCandidate clone() {
		long ret = bindings.FirstHopCandidate_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.FirstHopCandidate ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.FirstHopCandidate(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
