package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

/**
 * A trait indicating an object may generate message send events
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class MessageSendEventsProvider extends CommonBase {
	final bindings.LDKMessageSendEventsProvider bindings_instance;
	MessageSendEventsProvider(Object _dummy, long ptr) { super(ptr); bindings_instance = null; }
	private MessageSendEventsProvider(bindings.LDKMessageSendEventsProvider arg) {
		super(bindings.LDKMessageSendEventsProvider_new(arg));
		this.ptrs_to.add(arg);
		this.bindings_instance = arg;
	}
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.MessageSendEventsProvider_free(ptr); } super.finalize();
	}
	/**
	 * Destroys the object, freeing associated resources. After this call, any access
	 * to this object may result in a SEGFAULT or worse.
	 *
	 * You should generally NEVER call this method. You should let the garbage collector
	 * do this for you when it finalizes objects. However, it may be useful for types
	 * which represent locks and should be closed immediately to avoid holding locks
	 * until the GC runs.
	 */
	public void destroy() {
		if (ptr != 0) { bindings.MessageSendEventsProvider_free(ptr); }
		ptr = 0;
	}
	public static interface MessageSendEventsProviderInterface {
		/**
		 * Gets the list of pending events which were generated by previous actions, clearing the list
		 * in the process.
		 */
		MessageSendEvent[] get_and_clear_pending_msg_events();
	}
	private static class LDKMessageSendEventsProviderHolder { MessageSendEventsProvider held; }
	public static MessageSendEventsProvider new_impl(MessageSendEventsProviderInterface arg) {
		final LDKMessageSendEventsProviderHolder impl_holder = new LDKMessageSendEventsProviderHolder();
		impl_holder.held = new MessageSendEventsProvider(new bindings.LDKMessageSendEventsProvider() {
			@Override public long[] get_and_clear_pending_msg_events() {
				MessageSendEvent[] ret = arg.get_and_clear_pending_msg_events();
				Reference.reachabilityFence(arg);
				long[] result = ret != null ? Arrays.stream(ret).mapToLong(ret_conv_18 -> ret_conv_18 == null ? 0 : ret_conv_18.clone_ptr()).toArray() : null;
				for (MessageSendEvent ret_conv_18: ret) { if (impl_holder.held != null) { impl_holder.held.ptrs_to.add(ret_conv_18); }; };
				return result;
			}
		});
		return impl_holder.held;
	}
	/**
	 * Gets the list of pending events which were generated by previous actions, clearing the list
	 * in the process.
	 */
	public MessageSendEvent[] get_and_clear_pending_msg_events() {
		long[] ret = bindings.MessageSendEventsProvider_get_and_clear_pending_msg_events(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_18_len = ret.length;
		MessageSendEvent[] ret_conv_18_arr = new MessageSendEvent[ret_conv_18_len];
		for (int s = 0; s < ret_conv_18_len; s++) {
			long ret_conv_18 = ret[s];
			org.ldk.structs.MessageSendEvent ret_conv_18_hu_conv = org.ldk.structs.MessageSendEvent.constr_from_ptr(ret_conv_18);
			if (ret_conv_18_hu_conv != null) { ret_conv_18_hu_conv.ptrs_to.add(this); };
			ret_conv_18_arr[s] = ret_conv_18_hu_conv;
		}
		return ret_conv_18_arr;
	}

}
