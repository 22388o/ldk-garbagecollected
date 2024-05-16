package org.ldk.structs;

import org.ldk.impl.bindings;
import org.ldk.enums.*;
import org.ldk.util.*;
import java.util.Arrays;
import java.lang.ref.Reference;
import javax.annotation.Nullable;


/**
 * Builds a [`Refund`] for the \"offer for money\" flow.
 * 
 * See [module-level documentation] for usage.
 * 
 * [module-level documentation]: self
 */
@SuppressWarnings("unchecked") // We correctly assign various generic arrays
public class RefundMaybeWithDerivedMetadataBuilder extends CommonBase {
	RefundMaybeWithDerivedMetadataBuilder(Object _dummy, long ptr) { super(ptr); }
	@Override @SuppressWarnings("deprecation")
	protected void finalize() throws Throwable {
		super.finalize();
		if (ptr != 0) { bindings.RefundMaybeWithDerivedMetadataBuilder_free(ptr); }
	}

	long clone_ptr() {
		long ret = bindings.RefundMaybeWithDerivedMetadataBuilder_clone_ptr(this.ptr);
		Reference.reachabilityFence(this);
		return ret;
	}

	/**
	 * Creates a copy of the RefundMaybeWithDerivedMetadataBuilder
	 */
	public RefundMaybeWithDerivedMetadataBuilder clone() {
		long ret = bindings.RefundMaybeWithDerivedMetadataBuilder_clone(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		org.ldk.structs.RefundMaybeWithDerivedMetadataBuilder ret_hu_conv = null; if (ret < 0 || ret > 4096) { ret_hu_conv = new org.ldk.structs.RefundMaybeWithDerivedMetadataBuilder(null, ret); }
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(this); };
		return ret_hu_conv;
	}

	/**
	 * Creates a new builder for a refund using the [`Refund::payer_id`] for the public node id to
	 * send to if no [`Refund::paths`] are set. Otherwise, it may be a transient pubkey.
	 * 
	 * Additionally, sets the required (empty) [`Refund::description`], [`Refund::payer_metadata`],
	 * and [`Refund::amount_msats`].
	 * 
	 * # Note
	 * 
	 * If constructing a [`Refund`] for use with a [`ChannelManager`], use
	 * [`ChannelManager::create_refund_builder`] instead of [`RefundBuilder::new`].
	 * 
	 * [`ChannelManager`]: crate::ln::channelmanager::ChannelManager
	 * [`ChannelManager::create_refund_builder`]: crate::ln::channelmanager::ChannelManager::create_refund_builder
	 */
	public static Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ of(byte[] metadata, byte[] payer_id, long amount_msats) {
		long ret = bindings.RefundMaybeWithDerivedMetadataBuilder_new(metadata, InternalUtils.check_arr_len(payer_id, 33), amount_msats);
		Reference.reachabilityFence(metadata);
		Reference.reachabilityFence(payer_id);
		Reference.reachabilityFence(amount_msats);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ ret_hu_conv = Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Similar to [`RefundBuilder::new`] except, if [`RefundBuilder::path`] is called, the payer id
	 * is derived from the given [`ExpandedKey`] and nonce. This provides sender privacy by using a
	 * different payer id for each refund, assuming a different nonce is used.  Otherwise, the
	 * provided `node_id` is used for the payer id.
	 * 
	 * Also, sets the metadata when [`RefundBuilder::build`] is called such that it can be used to
	 * verify that an [`InvoiceRequest`] was produced for the refund given an [`ExpandedKey`].
	 * 
	 * The `payment_id` is encrypted in the metadata and should be unique. This ensures that only
	 * one invoice will be paid for the refund and that payments can be uniquely identified.
	 * 
	 * [`InvoiceRequest`]: crate::offers::invoice_request::InvoiceRequest
	 * [`ExpandedKey`]: crate::ln::inbound_payment::ExpandedKey
	 */
	public static Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ deriving_payer_id(byte[] node_id, org.ldk.structs.ExpandedKey expanded_key, org.ldk.structs.EntropySource entropy_source, long amount_msats, byte[] payment_id) {
		long ret = bindings.RefundMaybeWithDerivedMetadataBuilder_deriving_payer_id(InternalUtils.check_arr_len(node_id, 33), expanded_key.ptr, entropy_source.ptr, amount_msats, InternalUtils.check_arr_len(payment_id, 32));
		Reference.reachabilityFence(node_id);
		Reference.reachabilityFence(expanded_key);
		Reference.reachabilityFence(entropy_source);
		Reference.reachabilityFence(amount_msats);
		Reference.reachabilityFence(payment_id);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ ret_hu_conv = Result_RefundMaybeWithDerivedMetadataBuilderBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(expanded_key); };
		if (ret_hu_conv != null) { ret_hu_conv.ptrs_to.add(entropy_source); };
		return ret_hu_conv;
	}

	/**
	 * Sets the [`Refund::description`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void description(java.lang.String description) {
		bindings.RefundMaybeWithDerivedMetadataBuilder_description(this.ptr, description);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(description);
		if (this != null) { this.ptrs_to.add(this); };
	}

	/**
	 * Sets the [`Refund::absolute_expiry`] as seconds since the Unix epoch. Any expiry that has
	 * already passed is valid and can be checked for using [`Refund::is_expired`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void absolute_expiry(long absolute_expiry) {
		bindings.RefundMaybeWithDerivedMetadataBuilder_absolute_expiry(this.ptr, absolute_expiry);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(absolute_expiry);
		if (this != null) { this.ptrs_to.add(this); };
	}

	/**
	 * Sets the [`Refund::issuer`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void issuer(java.lang.String issuer) {
		bindings.RefundMaybeWithDerivedMetadataBuilder_issuer(this.ptr, issuer);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(issuer);
		if (this != null) { this.ptrs_to.add(this); };
	}

	/**
	 * Adds a blinded path to [`Refund::paths`]. Must include at least one path if only connected
	 * by private channels or if [`Refund::payer_id`] is not a public node id.
	 * 
	 * Successive calls to this method will add another blinded path. Caller is responsible for not
	 * adding duplicate paths.
	 */
	public void path(org.ldk.structs.BlindedPath path) {
		bindings.RefundMaybeWithDerivedMetadataBuilder_path(this.ptr, path.ptr);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(path);
		if (this != null) { this.ptrs_to.add(path); };
		if (this != null) { this.ptrs_to.add(this); };
	}

	/**
	 * Sets the [`Refund::chain`] of the given [`Network`] for paying an invoice. If not
	 * called, [`Network::Bitcoin`] is assumed.
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void chain(org.ldk.enums.Network network) {
		bindings.RefundMaybeWithDerivedMetadataBuilder_chain(this.ptr, network);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(network);
		if (this != null) { this.ptrs_to.add(this); };
	}

	/**
	 * Sets [`Refund::quantity`] of items. This is purely for informational purposes. It is useful
	 * when the refund pertains to a [`Bolt12Invoice`] that paid for more than one item from an
	 * [`Offer`] as specified by [`InvoiceRequest::quantity`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 * 
	 * [`Bolt12Invoice`]: crate::offers::invoice::Bolt12Invoice
	 * [`InvoiceRequest::quantity`]: crate::offers::invoice_request::InvoiceRequest::quantity
	 * [`Offer`]: crate::offers::offer::Offer
	 */
	public void quantity(long quantity) {
		bindings.RefundMaybeWithDerivedMetadataBuilder_quantity(this.ptr, quantity);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(quantity);
		if (this != null) { this.ptrs_to.add(this); };
	}

	/**
	 * Sets the [`Refund::payer_note`].
	 * 
	 * Successive calls to this method will override the previous setting.
	 */
	public void payer_note(java.lang.String payer_note) {
		bindings.RefundMaybeWithDerivedMetadataBuilder_payer_note(this.ptr, payer_note);
		Reference.reachabilityFence(this);
		Reference.reachabilityFence(payer_note);
		if (this != null) { this.ptrs_to.add(this); };
	}

	/**
	 * Builds a [`Refund`] after checking for valid semantics.
	 */
	public Result_RefundBolt12SemanticErrorZ build() {
		long ret = bindings.RefundMaybeWithDerivedMetadataBuilder_build(this.ptr);
		Reference.reachabilityFence(this);
		if (ret >= 0 && ret <= 4096) { return null; }
		Result_RefundBolt12SemanticErrorZ ret_hu_conv = Result_RefundBolt12SemanticErrorZ.constr_from_ptr(ret);
		if (this != null) { this.ptrs_to.add(this); };
		return ret_hu_conv;
	}

}
