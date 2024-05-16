package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Strategies available to retry payment path failures.
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class Retry extends CommonBase {
	private Retry(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.Retry_free(ptr); }
	}
	static Retry constr_from_ptr(long ptr) {
		bindings.LDKRetry raw_val = bindings.LDKRetry_ref_from_ptr(ptr);
		if (raw_val.getClass() == bindings.LDKRetry.Attempts.class) {
			return new Attempts(ptr, (bindings.LDKRetry.Attempts)raw_val);
		}
		if (raw_val.getClass() == bindings.LDKRetry.Timeout.class) {
			return new Timeout(ptr, (bindings.LDKRetry.Timeout)raw_val);
		}
		assert false; return null; // Unreachable without extending the (internal) bindings interface
	}

	/**
	 * Max number of attempts to retry payment.
	 * 
	 * Each attempt may be multiple HTLCs along multiple paths if the router decides to split up a
	 * retry, and may retry multiple failed HTLCs at once if they failed around the same time and
	 * were retried along a route from a single call to [`Router::find_route_with_id`].
	 */
	public final static class Attempts extends Retry {
		public final int attempts;
		private Attempts(long ptr, bindings.LDKRetry.Attempts obj) {
			super(null, ptr);
			this.attempts = obj.attempts;
		}
	}
	/**
	 * Time elapsed before abandoning retries for a payment. At least one attempt at payment is made;
	 * see [`PaymentParameters::expiry_time`] to avoid any attempt at payment after a specific time.
	 * 
	 * [`PaymentParameters::expiry_time`]: crate::routing::router::PaymentParameters::expiry_time
	 */
	public final static class Timeout extends Retry {
		public final long timeout;
		private Timeout(long ptr, bindings.LDKRetry.Timeout obj) {
			super(null, ptr);
			this.timeout = obj.timeout;
		}
	}
	long clone_ptr() {
		long ret = bindings.Retry_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the Retry
	 */
	public Retry clone() {
		long ret = bindings.Retry_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Retry ret_hu_conv = org.ldk.structs.Retry.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Attempts-variant Retry
	 */
	public static Retry attempts(int a) {
		long ret = bindings.Retry_attempts(a);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Retry ret_hu_conv = org.ldk.structs.Retry.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Utility method to constructs a new Timeout-variant Retry
	 */
	public static Retry timeout(long a) {
		long ret = bindings.Retry_timeout(a);
		Reference.reachabilityFence(a);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Retry ret_hu_conv = org.ldk.structs.Retry.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(ret_hu_conv); };
		return ret_hu_conv;
	}

	/**
	 * Checks if two Retrys contain equal inner contents.
	 * This ignores pointers and is_owned flags and looks at the values in fields.
	 */
	public boolean eq(org.ldk.structs.Retry b) {
		boolean ret = bindings.Retry_eq(this.ptr, b.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(b);
		return ret;
	}

	@Override public boolean equals(Object o) {
		if (!(o instanceof Retry)) return false;
		return this.eq((Retry)o);
	}
	/**
	 * Generates a non-cryptographic 64-bit hash of the Retry.
	 */
	public long hash() {
		long ret = bindings.Retry_hash(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	@Override public int hashCode() {
		return (int)this.hash();
	}
	/**
	 * Serialize the Retry object into a byte array which can be read by Retry_read
	 */
	public byte[] write() {
		byte[] ret = bindings.Retry_write(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Read a Retry from a byte array, created by Retry_write
	 */
	public static Result_RetryDecodeErrorZ read(byte[] ser) {
		long ret = bindings.Retry_read(ser);
		Reference.reachabilityFence(ser);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RetryDecodeErrorZ ret_hu_conv = Result_RetryDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

}
