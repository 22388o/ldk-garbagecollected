package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;

/**
 * Handler for custom onion messages. If you are using [`SimpleArcOnionMessenger`],
 * [`SimpleRefOnionMessenger`], or prefer to ignore inbound custom onion messages,
 * [`IgnoringMessageHandler`] must be provided to [`OnionMessenger::new`]. Otherwise, a custom
 * implementation of this trait must be provided, with [`CustomMessage`] specifying the supported
 * message types.
 * 
 * See [`OnionMessenger`] for example usage.
 * 
 * [`IgnoringMessageHandler`]: crate::ln::peer_handler::IgnoringMessageHandler
 * [`CustomMessage`]: Self::CustomMessage
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class CustomOnionMessageHandler extends CommonBase {
	final bindings.LDKCustomOnionMessageHandler bindings_instance;
	CustomOnionMessageHandler(Object _dummy, long ptr) { super(ptr); bindings_instance = null; }
	private CustomOnionMessageHandler(bindings.LDKCustomOnionMessageHandler arg) {
		super(bindings.LDKCustomOnionMessageHandler_new(arg));
		this.ptrs_to.add(arg);
		this.bindings_instance = arg;
	}
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		if (ptr != 0) { bindings.CustomOnionMessageHandler_free(ptr); } super.finalize();
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
		if (ptr != 0) { bindings.CustomOnionMessageHandler_free(ptr); }
		ptr = 0;
	}
	public static interface CustomOnionMessageHandlerInterface {
		/**
		 * Called with the custom message that was received, returning a response to send, if any.
		 * 
		 * The returned [`Self::CustomMessage`], if any, is enqueued to be sent by [`OnionMessenger`].
		 */
		Option_OnionMessageContentsZ handle_custom_message(OnionMessageContents msg);
		/**
		 * Read a custom message of type `message_type` from `buffer`, returning `Ok(None)` if the
		 * message type is unknown.
		 */
		Result_COption_OnionMessageContentsZDecodeErrorZ read_custom_message(long message_type, byte[] buffer);
		/**
		 * Releases any [`Self::CustomMessage`]s that need to be sent.
		 * 
		 * Typically, this is used for messages initiating a message flow rather than in response to
		 * another message. The latter should use the return value of [`Self::handle_custom_message`].
		 */
		ThreeTuple_OnionMessageContentsDestinationBlindedPathZ[] release_pending_custom_messages();
	}
	private static class LDKCustomOnionMessageHandlerHolder { CustomOnionMessageHandler held; }
	public static CustomOnionMessageHandler new_impl(CustomOnionMessageHandlerInterface arg) {
		final LDKCustomOnionMessageHandlerHolder impl_holder = new LDKCustomOnionMessageHandlerHolder();
		impl_holder.held = new CustomOnionMessageHandler(new bindings.LDKCustomOnionMessageHandler() {
			@Override public long handle_custom_message(long msg) {
				OnionMessageContents ret_hu_conv = new OnionMessageContents(null, msg);
				if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
				Option_OnionMessageContentsZ ret = arg.handle_custom_message(ret_hu_conv);
				Reference.reachabilityFence(arg);
				long result = ret == null ? 0 : ret.clone_ptr();
				if (impl_holder.held != null) { impl_holder.held.ptrs_to.add(ret); };
				return result;
			}
			@Override public long read_custom_message(long message_type, byte[] buffer) {
				Result_COption_OnionMessageContentsZDecodeErrorZ ret = arg.read_custom_message(message_type, buffer);
				Reference.reachabilityFence(arg);
				long result = ret == null ? 0 : ret.clone_ptr();
				return result;
			}
			@Override public long[] release_pending_custom_messages() {
				ThreeTuple_OnionMessageContentsDestinationBlindedPathZ[] ret = arg.release_pending_custom_messages();
				Reference.reachabilityFence(arg);
				long[] result = ret != null ? Arrays.stream(ret).mapToLong(ret_conv_56 -> ret_conv_56 == null ? 0 : ret_conv_56.clone_ptr()).toArray() : null;
				return result;
			}
		});
		return impl_holder.held;
	}
	/**
	 * Called with the custom message that was received, returning a response to send, if any.
	 * 
	 * The returned [`Self::CustomMessage`], if any, is enqueued to be sent by [`OnionMessenger`].
	 */
	public Option_OnionMessageContentsZ handle_custom_message(org.ldk.structs.OnionMessageContents msg) {
		long ret = bindings.CustomOnionMessageHandler_handle_custom_message(this.ptr, msg.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(msg);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.Option_OnionMessageContentsZ ret_hu_conv = org.ldk.structs.Option_OnionMessageContentsZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		if (this != null) { this.ptrs_to.add(msg); };
		return ret_hu_conv;
	}

	/**
	 * Read a custom message of type `message_type` from `buffer`, returning `Ok(None)` if the
	 * message type is unknown.
	 */
	public Result_COption_OnionMessageContentsZDecodeErrorZ read_custom_message(long message_type, byte[] buffer) {
		long ret = bindings.CustomOnionMessageHandler_read_custom_message(this.ptr, message_type, buffer);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(message_type);
		Reference.reachabilityFence(buffer);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_COption_OnionMessageContentsZDecodeErrorZ ret_hu_conv = Result_COption_OnionMessageContentsZDecodeErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Releases any [`Self::CustomMessage`]s that need to be sent.
	 * 
	 * Typically, this is used for messages initiating a message flow rather than in response to
	 * another message. The latter should use the return value of [`Self::handle_custom_message`].
	 */
	public ThreeTuple_OnionMessageContentsDestinationBlindedPathZ[] release_pending_custom_messages() {
		long[] ret = bindings.CustomOnionMessageHandler_release_pending_custom_messages(this.ptr);
		Reference.reachabilityFence(this);
		int ret_conv_56_len = ret.length;
		ThreeTuple_OnionMessageContentsDestinationBlindedPathZ[] ret_conv_56_arr = new ThreeTuple_OnionMessageContentsDestinationBlindedPathZ[ret_conv_56_len];
		for (int e = 0; e < ret_conv_56_len; e++) {
			long ret_conv_56 = ret[e];
			ThreeTuple_OnionMessageContentsDestinationBlindedPathZ ret_conv_56_hu_conv = new ThreeTuple_OnionMessageContentsDestinationBlindedPathZ(null, ret_conv_56);
			if (ret_conv_56_hu_conv != null) { ret_conv_56_hu_conv.ptrs_to.add(this); };
			ret_conv_56_arr[e] = ret_conv_56_hu_conv;
		}
		return ret_conv_56_arr;
	}

}