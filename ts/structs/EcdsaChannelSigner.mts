import { TxOut } from '../structs/TxOut.mjs';
import { TxIn } from '../structs/TxIn.mjs';
import { BigEndianScalar } from '../structs/BigEndianScalar.mjs';
import { Bolt11SemanticError } from '../enums/Bolt11SemanticError.mjs';
import { Bolt12SemanticError } from '../enums/Bolt12SemanticError.mjs';
import { COption_NoneZ } from '../enums/COption_NoneZ.mjs';
import { ChannelMonitorUpdateStatus } from '../enums/ChannelMonitorUpdateStatus.mjs';
import { ChannelShutdownState } from '../enums/ChannelShutdownState.mjs';
import { ConfirmationTarget } from '../enums/ConfirmationTarget.mjs';
import { CreationError } from '../enums/CreationError.mjs';
import { Currency } from '../enums/Currency.mjs';
import { HTLCClaim } from '../enums/HTLCClaim.mjs';
import { IOError } from '../enums/IOError.mjs';
import { Level } from '../enums/Level.mjs';
import { Network } from '../enums/Network.mjs';
import { PaymentFailureReason } from '../enums/PaymentFailureReason.mjs';
import { Recipient } from '../enums/Recipient.mjs';
import { RetryableSendFailure } from '../enums/RetryableSendFailure.mjs';
import { Secp256k1Error } from '../enums/Secp256k1Error.mjs';
import { SiPrefix } from '../enums/SiPrefix.mjs';
import { SocketAddressParseError } from '../enums/SocketAddressParseError.mjs';
import { UtxoLookupError } from '../enums/UtxoLookupError.mjs';
import { Bech32Error } from '../structs/Bech32Error.mjs';
import { Option_u64Z } from '../structs/Option_u64Z.mjs';
import { BlindedPath } from '../structs/BlindedPath.mjs';
import { Refund } from '../structs/Refund.mjs';
import { Bolt12ParseError } from '../structs/Bolt12ParseError.mjs';
import { Result_RefundBolt12ParseErrorZ } from '../structs/Result_RefundBolt12ParseErrorZ.mjs';
import { Retry } from '../structs/Retry.mjs';
import { DecodeError } from '../structs/DecodeError.mjs';
import { Result_RetryDecodeErrorZ } from '../structs/Result_RetryDecodeErrorZ.mjs';
import { ShutdownScript } from '../structs/ShutdownScript.mjs';
import { APIError } from '../structs/APIError.mjs';
import { Result_NoneAPIErrorZ } from '../structs/Result_NoneAPIErrorZ.mjs';
import { Option_ThirtyTwoBytesZ } from '../structs/Option_ThirtyTwoBytesZ.mjs';
import { Option_CVec_u8ZZ } from '../structs/Option_CVec_u8ZZ.mjs';
import { RecipientOnionFields } from '../structs/RecipientOnionFields.mjs';
import { Result_RecipientOnionFieldsDecodeErrorZ } from '../structs/Result_RecipientOnionFieldsDecodeErrorZ.mjs';
import { TwoTuple_u64CVec_u8ZZ } from '../structs/TwoTuple_u64CVec_u8ZZ.mjs';
import { Result_RecipientOnionFieldsNoneZ } from '../structs/Result_RecipientOnionFieldsNoneZ.mjs';
import { Option_CVec_ThirtyTwoBytesZZ } from '../structs/Option_CVec_ThirtyTwoBytesZZ.mjs';
import { Result_ThirtyTwoBytesNoneZ } from '../structs/Result_ThirtyTwoBytesNoneZ.mjs';
import { BlindedPayInfo } from '../structs/BlindedPayInfo.mjs';
import { Result_BlindedPayInfoDecodeErrorZ } from '../structs/Result_BlindedPayInfoDecodeErrorZ.mjs';
import { DelayedPaymentOutputDescriptor } from '../structs/DelayedPaymentOutputDescriptor.mjs';
import { Result_DelayedPaymentOutputDescriptorDecodeErrorZ } from '../structs/Result_DelayedPaymentOutputDescriptorDecodeErrorZ.mjs';
import { StaticPaymentOutputDescriptor } from '../structs/StaticPaymentOutputDescriptor.mjs';
import { Result_StaticPaymentOutputDescriptorDecodeErrorZ } from '../structs/Result_StaticPaymentOutputDescriptorDecodeErrorZ.mjs';
import { OutPoint } from '../structs/OutPoint.mjs';
import { SpendableOutputDescriptor } from '../structs/SpendableOutputDescriptor.mjs';
import { Result_SpendableOutputDescriptorDecodeErrorZ } from '../structs/Result_SpendableOutputDescriptorDecodeErrorZ.mjs';
import { Option_u32Z } from '../structs/Option_u32Z.mjs';
import { TwoTuple_CVec_u8ZusizeZ } from '../structs/TwoTuple_CVec_u8ZusizeZ.mjs';
import { Result_C2Tuple_CVec_u8ZusizeZNoneZ } from '../structs/Result_C2Tuple_CVec_u8ZusizeZNoneZ.mjs';
import { ChannelDerivationParameters } from '../structs/ChannelDerivationParameters.mjs';
import { Result_ChannelDerivationParametersDecodeErrorZ } from '../structs/Result_ChannelDerivationParametersDecodeErrorZ.mjs';
import { HTLCDescriptor } from '../structs/HTLCDescriptor.mjs';
import { Result_HTLCDescriptorDecodeErrorZ } from '../structs/Result_HTLCDescriptorDecodeErrorZ.mjs';
import { Result_NoneNoneZ } from '../structs/Result_NoneNoneZ.mjs';
import { TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ } from '../structs/TwoTuple_ECDSASignatureCVec_ECDSASignatureZZ.mjs';
import { Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ } from '../structs/Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ.mjs';
import { Result_ECDSASignatureNoneZ } from '../structs/Result_ECDSASignatureNoneZ.mjs';
import { Result_PublicKeyNoneZ } from '../structs/Result_PublicKeyNoneZ.mjs';
import { Option_BigEndianScalarZ } from '../structs/Option_BigEndianScalarZ.mjs';
import { Result_RecoverableSignatureNoneZ } from '../structs/Result_RecoverableSignatureNoneZ.mjs';
import { Result_SchnorrSignatureNoneZ } from '../structs/Result_SchnorrSignatureNoneZ.mjs';
import { CommitmentTransaction } from '../structs/CommitmentTransaction.mjs';
import { HolderCommitmentTransaction } from '../structs/HolderCommitmentTransaction.mjs';
import { HTLCOutputInCommitment } from '../structs/HTLCOutputInCommitment.mjs';
import { ClosingTransaction } from '../structs/ClosingTransaction.mjs';
import { UnsignedChannelAnnouncement } from '../structs/UnsignedChannelAnnouncement.mjs';
import { ChannelPublicKeys } from '../structs/ChannelPublicKeys.mjs';
import { ChannelTransactionParameters } from '../structs/ChannelTransactionParameters.mjs';
import { ChannelSigner, ChannelSignerInterface } from '../structs/ChannelSigner.mjs';
import { WriteableEcdsaChannelSigner, WriteableEcdsaChannelSignerInterface } from '../structs/WriteableEcdsaChannelSigner.mjs';
import { Result_WriteableEcdsaChannelSignerDecodeErrorZ } from '../structs/Result_WriteableEcdsaChannelSignerDecodeErrorZ.mjs';
import { Result_CVec_u8ZNoneZ } from '../structs/Result_CVec_u8ZNoneZ.mjs';
import { Result_ShutdownScriptNoneZ } from '../structs/Result_ShutdownScriptNoneZ.mjs';
import { Option_u16Z } from '../structs/Option_u16Z.mjs';
import { Option_boolZ } from '../structs/Option_boolZ.mjs';
import { Result_CVec_CVec_u8ZZNoneZ } from '../structs/Result_CVec_CVec_u8ZZNoneZ.mjs';
import { InMemorySigner } from '../structs/InMemorySigner.mjs';
import { Result_InMemorySignerDecodeErrorZ } from '../structs/Result_InMemorySignerDecodeErrorZ.mjs';
import { Result_TransactionNoneZ } from '../structs/Result_TransactionNoneZ.mjs';
import { ChannelDetails } from '../structs/ChannelDetails.mjs';
import { Route } from '../structs/Route.mjs';
import { LightningError } from '../structs/LightningError.mjs';
import { Result_RouteLightningErrorZ } from '../structs/Result_RouteLightningErrorZ.mjs';
import { InFlightHtlcs } from '../structs/InFlightHtlcs.mjs';
import { Result_InFlightHtlcsDecodeErrorZ } from '../structs/Result_InFlightHtlcsDecodeErrorZ.mjs';
import { RouteHop } from '../structs/RouteHop.mjs';
import { Result_RouteHopDecodeErrorZ } from '../structs/Result_RouteHopDecodeErrorZ.mjs';
import { BlindedHop } from '../structs/BlindedHop.mjs';
import { BlindedTail } from '../structs/BlindedTail.mjs';
import { Result_BlindedTailDecodeErrorZ } from '../structs/Result_BlindedTailDecodeErrorZ.mjs';
import { Path } from '../structs/Path.mjs';
import { Result_RouteDecodeErrorZ } from '../structs/Result_RouteDecodeErrorZ.mjs';
import { RouteParameters } from '../structs/RouteParameters.mjs';
import { Result_RouteParametersDecodeErrorZ } from '../structs/Result_RouteParametersDecodeErrorZ.mjs';
import { PaymentParameters } from '../structs/PaymentParameters.mjs';
import { Result_PaymentParametersDecodeErrorZ } from '../structs/Result_PaymentParametersDecodeErrorZ.mjs';
import { TwoTuple_BlindedPayInfoBlindedPathZ } from '../structs/TwoTuple_BlindedPayInfoBlindedPathZ.mjs';
import { RouteHint } from '../structs/RouteHint.mjs';
import { RouteHintHop } from '../structs/RouteHintHop.mjs';
import { Result_RouteHintDecodeErrorZ } from '../structs/Result_RouteHintDecodeErrorZ.mjs';
import { Result_RouteHintHopDecodeErrorZ } from '../structs/Result_RouteHintHopDecodeErrorZ.mjs';
import { FixedPenaltyScorer } from '../structs/FixedPenaltyScorer.mjs';
import { Result_FixedPenaltyScorerDecodeErrorZ } from '../structs/Result_FixedPenaltyScorerDecodeErrorZ.mjs';
import { NodeId } from '../structs/NodeId.mjs';
import { TwoTuple_u64u64Z } from '../structs/TwoTuple_u64u64Z.mjs';
import { Option_C2Tuple_u64u64ZZ } from '../structs/Option_C2Tuple_u64u64ZZ.mjs';
import { TwoTuple_Z } from '../structs/TwoTuple_Z.mjs';
import { TwoTuple__u1632_u1632Z } from '../structs/TwoTuple__u1632_u1632Z.mjs';
import { Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ } from '../structs/Option_C2Tuple_ThirtyTwoU16sThirtyTwoU16sZZ.mjs';
import { Option_f64Z } from '../structs/Option_f64Z.mjs';
import { Record } from '../structs/Record.mjs';
import { Logger, LoggerInterface } from '../structs/Logger.mjs';
import { NetworkGraph } from '../structs/NetworkGraph.mjs';
import { ProbabilisticScorer } from '../structs/ProbabilisticScorer.mjs';
import { Result_ProbabilisticScorerDecodeErrorZ } from '../structs/Result_ProbabilisticScorerDecodeErrorZ.mjs';
import { TwoTuple_usizeTransactionZ } from '../structs/TwoTuple_usizeTransactionZ.mjs';
import { TwoTuple_ThirtyTwoBytesCOption_ThirtyTwoBytesZZ } from '../structs/TwoTuple_ThirtyTwoBytesCOption_ThirtyTwoBytesZZ.mjs';
import { Result_ChannelMonitorUpdateStatusNoneZ } from '../structs/Result_ChannelMonitorUpdateStatusNoneZ.mjs';
import { HTLCUpdate } from '../structs/HTLCUpdate.mjs';
import { MonitorEvent } from '../structs/MonitorEvent.mjs';
import { ThreeTuple_OutPointCVec_MonitorEventZPublicKeyZ } from '../structs/ThreeTuple_OutPointCVec_MonitorEventZPublicKeyZ.mjs';
import { InitFeatures } from '../structs/InitFeatures.mjs';
import { Result_InitFeaturesDecodeErrorZ } from '../structs/Result_InitFeaturesDecodeErrorZ.mjs';
import { ChannelFeatures } from '../structs/ChannelFeatures.mjs';
import { Result_ChannelFeaturesDecodeErrorZ } from '../structs/Result_ChannelFeaturesDecodeErrorZ.mjs';
import { NodeFeatures } from '../structs/NodeFeatures.mjs';
import { Result_NodeFeaturesDecodeErrorZ } from '../structs/Result_NodeFeaturesDecodeErrorZ.mjs';
import { Bolt11InvoiceFeatures } from '../structs/Bolt11InvoiceFeatures.mjs';
import { Result_Bolt11InvoiceFeaturesDecodeErrorZ } from '../structs/Result_Bolt11InvoiceFeaturesDecodeErrorZ.mjs';
import { Bolt12InvoiceFeatures } from '../structs/Bolt12InvoiceFeatures.mjs';
import { Result_Bolt12InvoiceFeaturesDecodeErrorZ } from '../structs/Result_Bolt12InvoiceFeaturesDecodeErrorZ.mjs';
import { BlindedHopFeatures } from '../structs/BlindedHopFeatures.mjs';
import { Result_BlindedHopFeaturesDecodeErrorZ } from '../structs/Result_BlindedHopFeaturesDecodeErrorZ.mjs';
import { ChannelTypeFeatures } from '../structs/ChannelTypeFeatures.mjs';
import { Result_ChannelTypeFeaturesDecodeErrorZ } from '../structs/Result_ChannelTypeFeaturesDecodeErrorZ.mjs';
import { Offer } from '../structs/Offer.mjs';
import { Result_OfferBolt12ParseErrorZ } from '../structs/Result_OfferBolt12ParseErrorZ.mjs';
import { Result_PublicKeySecp256k1ErrorZ } from '../structs/Result_PublicKeySecp256k1ErrorZ.mjs';
import { Result_NodeIdDecodeErrorZ } from '../structs/Result_NodeIdDecodeErrorZ.mjs';
import { ChannelUpdate } from '../structs/ChannelUpdate.mjs';
import { NetworkUpdate } from '../structs/NetworkUpdate.mjs';
import { Option_NetworkUpdateZ } from '../structs/Option_NetworkUpdateZ.mjs';
import { Result_COption_NetworkUpdateZDecodeErrorZ } from '../structs/Result_COption_NetworkUpdateZDecodeErrorZ.mjs';
import { Result_TxOutUtxoLookupErrorZ } from '../structs/Result_TxOutUtxoLookupErrorZ.mjs';
import { UtxoFuture } from '../structs/UtxoFuture.mjs';
import { UtxoResult } from '../structs/UtxoResult.mjs';
import { UtxoLookup, UtxoLookupInterface } from '../structs/UtxoLookup.mjs';
import { Option_UtxoLookupZ } from '../structs/Option_UtxoLookupZ.mjs';
import { Result_NoneLightningErrorZ } from '../structs/Result_NoneLightningErrorZ.mjs';
import { Result_boolLightningErrorZ } from '../structs/Result_boolLightningErrorZ.mjs';
import { ChannelAnnouncement } from '../structs/ChannelAnnouncement.mjs';
import { ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ } from '../structs/ThreeTuple_ChannelAnnouncementChannelUpdateChannelUpdateZ.mjs';
import { Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ } from '../structs/Option_C3Tuple_ChannelAnnouncementChannelUpdateChannelUpdateZZ.mjs';
import { AcceptChannel } from '../structs/AcceptChannel.mjs';
import { AcceptChannelV2 } from '../structs/AcceptChannelV2.mjs';
import { OpenChannel } from '../structs/OpenChannel.mjs';
import { OpenChannelV2 } from '../structs/OpenChannelV2.mjs';
import { FundingCreated } from '../structs/FundingCreated.mjs';
import { FundingSigned } from '../structs/FundingSigned.mjs';
import { TxAddInput } from '../structs/TxAddInput.mjs';
import { TxAddOutput } from '../structs/TxAddOutput.mjs';
import { TxRemoveInput } from '../structs/TxRemoveInput.mjs';
import { TxRemoveOutput } from '../structs/TxRemoveOutput.mjs';
import { TxComplete } from '../structs/TxComplete.mjs';
import { TxSignatures } from '../structs/TxSignatures.mjs';
import { TxInitRbf } from '../structs/TxInitRbf.mjs';
import { TxAckRbf } from '../structs/TxAckRbf.mjs';
import { TxAbort } from '../structs/TxAbort.mjs';
import { ChannelReady } from '../structs/ChannelReady.mjs';
import { AnnouncementSignatures } from '../structs/AnnouncementSignatures.mjs';
import { CommitmentUpdate } from '../structs/CommitmentUpdate.mjs';
import { RevokeAndACK } from '../structs/RevokeAndACK.mjs';
import { ClosingSigned } from '../structs/ClosingSigned.mjs';
import { Shutdown } from '../structs/Shutdown.mjs';
import { ChannelReestablish } from '../structs/ChannelReestablish.mjs';
import { NodeAnnouncement } from '../structs/NodeAnnouncement.mjs';
import { ErrorMessage } from '../structs/ErrorMessage.mjs';
import { WarningMessage } from '../structs/WarningMessage.mjs';
import { ErrorAction } from '../structs/ErrorAction.mjs';
import { QueryChannelRange } from '../structs/QueryChannelRange.mjs';
import { QueryShortChannelIds } from '../structs/QueryShortChannelIds.mjs';
import { ReplyChannelRange } from '../structs/ReplyChannelRange.mjs';
import { GossipTimestampFilter } from '../structs/GossipTimestampFilter.mjs';
import { MessageSendEvent } from '../structs/MessageSendEvent.mjs';
import { ChannelUpdateInfo } from '../structs/ChannelUpdateInfo.mjs';
import { Result_ChannelUpdateInfoDecodeErrorZ } from '../structs/Result_ChannelUpdateInfoDecodeErrorZ.mjs';
import { ChannelInfo } from '../structs/ChannelInfo.mjs';
import { Result_ChannelInfoDecodeErrorZ } from '../structs/Result_ChannelInfoDecodeErrorZ.mjs';
import { RoutingFees } from '../structs/RoutingFees.mjs';
import { Result_RoutingFeesDecodeErrorZ } from '../structs/Result_RoutingFeesDecodeErrorZ.mjs';
import { Hostname } from '../structs/Hostname.mjs';
import { SocketAddress } from '../structs/SocketAddress.mjs';
import { NodeAnnouncementInfo } from '../structs/NodeAnnouncementInfo.mjs';
import { Result_NodeAnnouncementInfoDecodeErrorZ } from '../structs/Result_NodeAnnouncementInfoDecodeErrorZ.mjs';
import { NodeAlias } from '../structs/NodeAlias.mjs';
import { Result_NodeAliasDecodeErrorZ } from '../structs/Result_NodeAliasDecodeErrorZ.mjs';
import { NodeInfo } from '../structs/NodeInfo.mjs';
import { Result_NodeInfoDecodeErrorZ } from '../structs/Result_NodeInfoDecodeErrorZ.mjs';
import { Result_NetworkGraphDecodeErrorZ } from '../structs/Result_NetworkGraphDecodeErrorZ.mjs';
import { Option_CVec_SocketAddressZZ } from '../structs/Option_CVec_SocketAddressZZ.mjs';
import { Utxo } from '../structs/Utxo.mjs';
import { Option_TxOutZ } from '../structs/Option_TxOutZ.mjs';
import { Input } from '../structs/Input.mjs';
import { CoinSelection } from '../structs/CoinSelection.mjs';
import { Result_CoinSelectionNoneZ } from '../structs/Result_CoinSelectionNoneZ.mjs';
import { Result_CVec_UtxoZNoneZ } from '../structs/Result_CVec_UtxoZNoneZ.mjs';
import { TwoTuple_u64u16Z } from '../structs/TwoTuple_u64u16Z.mjs';
import { Option_C2Tuple_u64u16ZZ } from '../structs/Option_C2Tuple_u64u16ZZ.mjs';
import { Option_ChannelShutdownStateZ } from '../structs/Option_ChannelShutdownStateZ.mjs';
import { Result_ThirtyTwoBytesAPIErrorZ } from '../structs/Result_ThirtyTwoBytesAPIErrorZ.mjs';
import { RecentPaymentDetails } from '../structs/RecentPaymentDetails.mjs';
import { PaymentSendFailure } from '../structs/PaymentSendFailure.mjs';
import { Result_NonePaymentSendFailureZ } from '../structs/Result_NonePaymentSendFailureZ.mjs';
import { Result_NoneRetryableSendFailureZ } from '../structs/Result_NoneRetryableSendFailureZ.mjs';
import { Result_ThirtyTwoBytesPaymentSendFailureZ } from '../structs/Result_ThirtyTwoBytesPaymentSendFailureZ.mjs';
import { Result_ThirtyTwoBytesRetryableSendFailureZ } from '../structs/Result_ThirtyTwoBytesRetryableSendFailureZ.mjs';
import { TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ } from '../structs/TwoTuple_ThirtyTwoBytesThirtyTwoBytesZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZPaymentSendFailureZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZPaymentSendFailureZ.mjs';
import { ProbeSendFailure } from '../structs/ProbeSendFailure.mjs';
import { Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ } from '../structs/Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbeSendFailureZ.mjs';
import { TwoTuple_ThirtyTwoBytesPublicKeyZ } from '../structs/TwoTuple_ThirtyTwoBytesPublicKeyZ.mjs';
import { Option_StrZ } from '../structs/Option_StrZ.mjs';
import { Result_NoneBolt12SemanticErrorZ } from '../structs/Result_NoneBolt12SemanticErrorZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZNoneZ.mjs';
import { InvoiceRequest } from '../structs/InvoiceRequest.mjs';
import { Bolt12Invoice } from '../structs/Bolt12Invoice.mjs';
import { InvoiceError } from '../structs/InvoiceError.mjs';
import { OffersMessage } from '../structs/OffersMessage.mjs';
import { Option_OffersMessageZ } from '../structs/Option_OffersMessageZ.mjs';
import { Destination } from '../structs/Destination.mjs';
import { ThreeTuple_OffersMessageDestinationBlindedPathZ } from '../structs/ThreeTuple_OffersMessageDestinationBlindedPathZ.mjs';
import { CounterpartyForwardingInfo } from '../structs/CounterpartyForwardingInfo.mjs';
import { Result_CounterpartyForwardingInfoDecodeErrorZ } from '../structs/Result_CounterpartyForwardingInfoDecodeErrorZ.mjs';
import { ChannelCounterparty } from '../structs/ChannelCounterparty.mjs';
import { Result_ChannelCounterpartyDecodeErrorZ } from '../structs/Result_ChannelCounterpartyDecodeErrorZ.mjs';
import { Result_ChannelDetailsDecodeErrorZ } from '../structs/Result_ChannelDetailsDecodeErrorZ.mjs';
import { PhantomRouteHints } from '../structs/PhantomRouteHints.mjs';
import { Result_PhantomRouteHintsDecodeErrorZ } from '../structs/Result_PhantomRouteHintsDecodeErrorZ.mjs';
import { Result_ChannelShutdownStateDecodeErrorZ } from '../structs/Result_ChannelShutdownStateDecodeErrorZ.mjs';
import { ChannelMonitor } from '../structs/ChannelMonitor.mjs';
import { ChannelMonitorUpdate } from '../structs/ChannelMonitorUpdate.mjs';
import { Watch, WatchInterface } from '../structs/Watch.mjs';
import { BroadcasterInterface, BroadcasterInterfaceInterface } from '../structs/BroadcasterInterface.mjs';
import { EntropySource, EntropySourceInterface } from '../structs/EntropySource.mjs';
import { UnsignedInvoiceRequest } from '../structs/UnsignedInvoiceRequest.mjs';
import { UnsignedBolt12Invoice } from '../structs/UnsignedBolt12Invoice.mjs';
import { UnsignedChannelUpdate } from '../structs/UnsignedChannelUpdate.mjs';
import { UnsignedNodeAnnouncement } from '../structs/UnsignedNodeAnnouncement.mjs';
import { UnsignedGossipMessage } from '../structs/UnsignedGossipMessage.mjs';
import { NodeSigner, NodeSignerInterface } from '../structs/NodeSigner.mjs';
import { SignerProvider, SignerProviderInterface } from '../structs/SignerProvider.mjs';
import { FeeEstimator, FeeEstimatorInterface } from '../structs/FeeEstimator.mjs';
import { Router, RouterInterface } from '../structs/Router.mjs';
import { ChannelManager } from '../structs/ChannelManager.mjs';
import { TwoTuple_ThirtyTwoBytesChannelManagerZ } from '../structs/TwoTuple_ThirtyTwoBytesChannelManagerZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesChannelManagerZDecodeErrorZ.mjs';
import { MaxDustHTLCExposure } from '../structs/MaxDustHTLCExposure.mjs';
import { Result_MaxDustHTLCExposureDecodeErrorZ } from '../structs/Result_MaxDustHTLCExposureDecodeErrorZ.mjs';
import { ChannelConfig } from '../structs/ChannelConfig.mjs';
import { Result_ChannelConfigDecodeErrorZ } from '../structs/Result_ChannelConfigDecodeErrorZ.mjs';
import { Option_MaxDustHTLCExposureZ } from '../structs/Option_MaxDustHTLCExposureZ.mjs';
import { Option_APIErrorZ } from '../structs/Option_APIErrorZ.mjs';
import { Result_COption_APIErrorZDecodeErrorZ } from '../structs/Result_COption_APIErrorZDecodeErrorZ.mjs';
import { Result_ChannelMonitorUpdateDecodeErrorZ } from '../structs/Result_ChannelMonitorUpdateDecodeErrorZ.mjs';
import { Option_MonitorEventZ } from '../structs/Option_MonitorEventZ.mjs';
import { Result_COption_MonitorEventZDecodeErrorZ } from '../structs/Result_COption_MonitorEventZDecodeErrorZ.mjs';
import { Result_HTLCUpdateDecodeErrorZ } from '../structs/Result_HTLCUpdateDecodeErrorZ.mjs';
import { TwoTuple_OutPointCVec_u8ZZ } from '../structs/TwoTuple_OutPointCVec_u8ZZ.mjs';
import { TwoTuple_u32CVec_u8ZZ } from '../structs/TwoTuple_u32CVec_u8ZZ.mjs';
import { TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32CVec_u8ZZZZ } from '../structs/TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32CVec_u8ZZZZ.mjs';
import { TwoTuple_u32TxOutZ } from '../structs/TwoTuple_u32TxOutZ.mjs';
import { TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ } from '../structs/TwoTuple_ThirtyTwoBytesCVec_C2Tuple_u32TxOutZZZ.mjs';
import { Balance } from '../structs/Balance.mjs';
import { TwoTuple_ThirtyTwoBytesChannelMonitorZ } from '../structs/TwoTuple_ThirtyTwoBytesChannelMonitorZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesChannelMonitorZDecodeErrorZ.mjs';
import { Type, TypeInterface } from '../structs/Type.mjs';
import { TwoTuple_PublicKeyTypeZ } from '../structs/TwoTuple_PublicKeyTypeZ.mjs';
import { OnionMessageContents, OnionMessageContentsInterface } from '../structs/OnionMessageContents.mjs';
import { Option_OnionMessageContentsZ } from '../structs/Option_OnionMessageContentsZ.mjs';
import { Result_COption_OnionMessageContentsZDecodeErrorZ } from '../structs/Result_COption_OnionMessageContentsZDecodeErrorZ.mjs';
import { ThreeTuple_OnionMessageContentsDestinationBlindedPathZ } from '../structs/ThreeTuple_OnionMessageContentsDestinationBlindedPathZ.mjs';
import { Option_TypeZ } from '../structs/Option_TypeZ.mjs';
import { Result_COption_TypeZDecodeErrorZ } from '../structs/Result_COption_TypeZDecodeErrorZ.mjs';
import { Option_SocketAddressZ } from '../structs/Option_SocketAddressZ.mjs';
import { TwoTuple_PublicKeyCOption_SocketAddressZZ } from '../structs/TwoTuple_PublicKeyCOption_SocketAddressZZ.mjs';
import { PeerHandleError } from '../structs/PeerHandleError.mjs';
import { Result_CVec_u8ZPeerHandleErrorZ } from '../structs/Result_CVec_u8ZPeerHandleErrorZ.mjs';
import { Result_NonePeerHandleErrorZ } from '../structs/Result_NonePeerHandleErrorZ.mjs';
import { Result_boolPeerHandleErrorZ } from '../structs/Result_boolPeerHandleErrorZ.mjs';
import { GraphSyncError } from '../structs/GraphSyncError.mjs';
import { Result_u32GraphSyncErrorZ } from '../structs/Result_u32GraphSyncErrorZ.mjs';
import { Result_CVec_u8ZIOErrorZ } from '../structs/Result_CVec_u8ZIOErrorZ.mjs';
import { Result_NoneIOErrorZ } from '../structs/Result_NoneIOErrorZ.mjs';
import { Result_CVec_StrZIOErrorZ } from '../structs/Result_CVec_StrZIOErrorZ.mjs';
import { Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ } from '../structs/Result_CVec_C2Tuple_ThirtyTwoBytesChannelMonitorZZIOErrorZ.mjs';
import { Result_C2Tuple_ThirtyTwoBytesChannelMonitorZIOErrorZ } from '../structs/Result_C2Tuple_ThirtyTwoBytesChannelMonitorZIOErrorZ.mjs';
import { Option_SecretKeyZ } from '../structs/Option_SecretKeyZ.mjs';
import { VerifiedInvoiceRequest } from '../structs/VerifiedInvoiceRequest.mjs';
import { Result_VerifiedInvoiceRequestNoneZ } from '../structs/Result_VerifiedInvoiceRequestNoneZ.mjs';
import { Option_i64Z } from '../structs/Option_i64Z.mjs';
import { Result_SocketAddressDecodeErrorZ } from '../structs/Result_SocketAddressDecodeErrorZ.mjs';
import { Result_SocketAddressSocketAddressParseErrorZ } from '../structs/Result_SocketAddressSocketAddressParseErrorZ.mjs';
import { UpdateAddHTLC } from '../structs/UpdateAddHTLC.mjs';
import { UpdateFulfillHTLC } from '../structs/UpdateFulfillHTLC.mjs';
import { UpdateFailHTLC } from '../structs/UpdateFailHTLC.mjs';
import { UpdateFailMalformedHTLC } from '../structs/UpdateFailMalformedHTLC.mjs';
import { Result_AcceptChannelDecodeErrorZ } from '../structs/Result_AcceptChannelDecodeErrorZ.mjs';
import { Result_AcceptChannelV2DecodeErrorZ } from '../structs/Result_AcceptChannelV2DecodeErrorZ.mjs';
import { Result_TxAddInputDecodeErrorZ } from '../structs/Result_TxAddInputDecodeErrorZ.mjs';
import { Result_TxAddOutputDecodeErrorZ } from '../structs/Result_TxAddOutputDecodeErrorZ.mjs';
import { Result_TxRemoveInputDecodeErrorZ } from '../structs/Result_TxRemoveInputDecodeErrorZ.mjs';
import { Result_TxRemoveOutputDecodeErrorZ } from '../structs/Result_TxRemoveOutputDecodeErrorZ.mjs';
import { Result_TxCompleteDecodeErrorZ } from '../structs/Result_TxCompleteDecodeErrorZ.mjs';
import { Result_TxSignaturesDecodeErrorZ } from '../structs/Result_TxSignaturesDecodeErrorZ.mjs';
import { Result_TxInitRbfDecodeErrorZ } from '../structs/Result_TxInitRbfDecodeErrorZ.mjs';
import { Result_TxAckRbfDecodeErrorZ } from '../structs/Result_TxAckRbfDecodeErrorZ.mjs';
import { Result_TxAbortDecodeErrorZ } from '../structs/Result_TxAbortDecodeErrorZ.mjs';
import { Result_AnnouncementSignaturesDecodeErrorZ } from '../structs/Result_AnnouncementSignaturesDecodeErrorZ.mjs';
import { Result_ChannelReestablishDecodeErrorZ } from '../structs/Result_ChannelReestablishDecodeErrorZ.mjs';
import { Result_ClosingSignedDecodeErrorZ } from '../structs/Result_ClosingSignedDecodeErrorZ.mjs';
import { ClosingSignedFeeRange } from '../structs/ClosingSignedFeeRange.mjs';
import { Result_ClosingSignedFeeRangeDecodeErrorZ } from '../structs/Result_ClosingSignedFeeRangeDecodeErrorZ.mjs';
import { CommitmentSigned } from '../structs/CommitmentSigned.mjs';
import { Result_CommitmentSignedDecodeErrorZ } from '../structs/Result_CommitmentSignedDecodeErrorZ.mjs';
import { Result_FundingCreatedDecodeErrorZ } from '../structs/Result_FundingCreatedDecodeErrorZ.mjs';
import { Result_FundingSignedDecodeErrorZ } from '../structs/Result_FundingSignedDecodeErrorZ.mjs';
import { Result_ChannelReadyDecodeErrorZ } from '../structs/Result_ChannelReadyDecodeErrorZ.mjs';
import { Init } from '../structs/Init.mjs';
import { Result_InitDecodeErrorZ } from '../structs/Result_InitDecodeErrorZ.mjs';
import { Result_OpenChannelDecodeErrorZ } from '../structs/Result_OpenChannelDecodeErrorZ.mjs';
import { Result_OpenChannelV2DecodeErrorZ } from '../structs/Result_OpenChannelV2DecodeErrorZ.mjs';
import { Result_RevokeAndACKDecodeErrorZ } from '../structs/Result_RevokeAndACKDecodeErrorZ.mjs';
import { Result_ShutdownDecodeErrorZ } from '../structs/Result_ShutdownDecodeErrorZ.mjs';
import { Result_UpdateFailHTLCDecodeErrorZ } from '../structs/Result_UpdateFailHTLCDecodeErrorZ.mjs';
import { Result_UpdateFailMalformedHTLCDecodeErrorZ } from '../structs/Result_UpdateFailMalformedHTLCDecodeErrorZ.mjs';
import { UpdateFee } from '../structs/UpdateFee.mjs';
import { Result_UpdateFeeDecodeErrorZ } from '../structs/Result_UpdateFeeDecodeErrorZ.mjs';
import { Result_UpdateFulfillHTLCDecodeErrorZ } from '../structs/Result_UpdateFulfillHTLCDecodeErrorZ.mjs';
import { Result_UpdateAddHTLCDecodeErrorZ } from '../structs/Result_UpdateAddHTLCDecodeErrorZ.mjs';
import { OnionMessage } from '../structs/OnionMessage.mjs';
import { Result_OnionMessageDecodeErrorZ } from '../structs/Result_OnionMessageDecodeErrorZ.mjs';
import { Ping } from '../structs/Ping.mjs';
import { Result_PingDecodeErrorZ } from '../structs/Result_PingDecodeErrorZ.mjs';
import { Pong } from '../structs/Pong.mjs';
import { Result_PongDecodeErrorZ } from '../structs/Result_PongDecodeErrorZ.mjs';
import { Result_UnsignedChannelAnnouncementDecodeErrorZ } from '../structs/Result_UnsignedChannelAnnouncementDecodeErrorZ.mjs';
import { Result_ChannelAnnouncementDecodeErrorZ } from '../structs/Result_ChannelAnnouncementDecodeErrorZ.mjs';
import { Result_UnsignedChannelUpdateDecodeErrorZ } from '../structs/Result_UnsignedChannelUpdateDecodeErrorZ.mjs';
import { Result_ChannelUpdateDecodeErrorZ } from '../structs/Result_ChannelUpdateDecodeErrorZ.mjs';
import { Result_ErrorMessageDecodeErrorZ } from '../structs/Result_ErrorMessageDecodeErrorZ.mjs';
import { Result_WarningMessageDecodeErrorZ } from '../structs/Result_WarningMessageDecodeErrorZ.mjs';
import { Result_UnsignedNodeAnnouncementDecodeErrorZ } from '../structs/Result_UnsignedNodeAnnouncementDecodeErrorZ.mjs';
import { Result_NodeAnnouncementDecodeErrorZ } from '../structs/Result_NodeAnnouncementDecodeErrorZ.mjs';
import { Result_QueryShortChannelIdsDecodeErrorZ } from '../structs/Result_QueryShortChannelIdsDecodeErrorZ.mjs';
import { ReplyShortChannelIdsEnd } from '../structs/ReplyShortChannelIdsEnd.mjs';
import { Result_ReplyShortChannelIdsEndDecodeErrorZ } from '../structs/Result_ReplyShortChannelIdsEndDecodeErrorZ.mjs';
import { Result_QueryChannelRangeDecodeErrorZ } from '../structs/Result_QueryChannelRangeDecodeErrorZ.mjs';
import { Result_ReplyChannelRangeDecodeErrorZ } from '../structs/Result_ReplyChannelRangeDecodeErrorZ.mjs';
import { Result_GossipTimestampFilterDecodeErrorZ } from '../structs/Result_GossipTimestampFilterDecodeErrorZ.mjs';
import { Bolt11Invoice } from '../structs/Bolt11Invoice.mjs';
import { SignOrCreationError } from '../structs/SignOrCreationError.mjs';
import { Result_Bolt11InvoiceSignOrCreationErrorZ } from '../structs/Result_Bolt11InvoiceSignOrCreationErrorZ.mjs';
import { Result_OffersMessageDecodeErrorZ } from '../structs/Result_OffersMessageDecodeErrorZ.mjs';
import { Option_HTLCClaimZ } from '../structs/Option_HTLCClaimZ.mjs';
import { CounterpartyCommitmentSecrets } from '../structs/CounterpartyCommitmentSecrets.mjs';
import { Result_CounterpartyCommitmentSecretsDecodeErrorZ } from '../structs/Result_CounterpartyCommitmentSecretsDecodeErrorZ.mjs';
import { TxCreationKeys } from '../structs/TxCreationKeys.mjs';
import { Result_TxCreationKeysDecodeErrorZ } from '../structs/Result_TxCreationKeysDecodeErrorZ.mjs';
import { Result_ChannelPublicKeysDecodeErrorZ } from '../structs/Result_ChannelPublicKeysDecodeErrorZ.mjs';
import { Result_HTLCOutputInCommitmentDecodeErrorZ } from '../structs/Result_HTLCOutputInCommitmentDecodeErrorZ.mjs';
import { CounterpartyChannelTransactionParameters } from '../structs/CounterpartyChannelTransactionParameters.mjs';
import { Result_CounterpartyChannelTransactionParametersDecodeErrorZ } from '../structs/Result_CounterpartyChannelTransactionParametersDecodeErrorZ.mjs';
import { Result_ChannelTransactionParametersDecodeErrorZ } from '../structs/Result_ChannelTransactionParametersDecodeErrorZ.mjs';
import { Result_HolderCommitmentTransactionDecodeErrorZ } from '../structs/Result_HolderCommitmentTransactionDecodeErrorZ.mjs';
import { BuiltCommitmentTransaction } from '../structs/BuiltCommitmentTransaction.mjs';
import { Result_BuiltCommitmentTransactionDecodeErrorZ } from '../structs/Result_BuiltCommitmentTransactionDecodeErrorZ.mjs';
import { TrustedClosingTransaction } from '../structs/TrustedClosingTransaction.mjs';
import { Result_TrustedClosingTransactionNoneZ } from '../structs/Result_TrustedClosingTransactionNoneZ.mjs';
import { Result_CommitmentTransactionDecodeErrorZ } from '../structs/Result_CommitmentTransactionDecodeErrorZ.mjs';
import { TrustedCommitmentTransaction } from '../structs/TrustedCommitmentTransaction.mjs';
import { Result_TrustedCommitmentTransactionNoneZ } from '../structs/Result_TrustedCommitmentTransactionNoneZ.mjs';
import { Result_CVec_ECDSASignatureZNoneZ } from '../structs/Result_CVec_ECDSASignatureZNoneZ.mjs';
import { Option_usizeZ } from '../structs/Option_usizeZ.mjs';
import { Result_ShutdownScriptDecodeErrorZ } from '../structs/Result_ShutdownScriptDecodeErrorZ.mjs';
import { InvalidShutdownScript } from '../structs/InvalidShutdownScript.mjs';
import { Result_ShutdownScriptInvalidShutdownScriptZ } from '../structs/Result_ShutdownScriptInvalidShutdownScriptZ.mjs';
import { PaymentPurpose } from '../structs/PaymentPurpose.mjs';
import { Result_PaymentPurposeDecodeErrorZ } from '../structs/Result_PaymentPurposeDecodeErrorZ.mjs';
import { ClaimedHTLC } from '../structs/ClaimedHTLC.mjs';
import { Result_ClaimedHTLCDecodeErrorZ } from '../structs/Result_ClaimedHTLCDecodeErrorZ.mjs';
import { PathFailure } from '../structs/PathFailure.mjs';
import { Option_PathFailureZ } from '../structs/Option_PathFailureZ.mjs';
import { Result_COption_PathFailureZDecodeErrorZ } from '../structs/Result_COption_PathFailureZDecodeErrorZ.mjs';
import { UntrustedString } from '../structs/UntrustedString.mjs';
import { ClosureReason } from '../structs/ClosureReason.mjs';
import { Option_ClosureReasonZ } from '../structs/Option_ClosureReasonZ.mjs';
import { Result_COption_ClosureReasonZDecodeErrorZ } from '../structs/Result_COption_ClosureReasonZDecodeErrorZ.mjs';
import { HTLCDestination } from '../structs/HTLCDestination.mjs';
import { Option_HTLCDestinationZ } from '../structs/Option_HTLCDestinationZ.mjs';
import { Result_COption_HTLCDestinationZDecodeErrorZ } from '../structs/Result_COption_HTLCDestinationZDecodeErrorZ.mjs';
import { Result_PaymentFailureReasonDecodeErrorZ } from '../structs/Result_PaymentFailureReasonDecodeErrorZ.mjs';
import { Option_U128Z } from '../structs/Option_U128Z.mjs';
import { Option_PaymentFailureReasonZ } from '../structs/Option_PaymentFailureReasonZ.mjs';
import { AnchorDescriptor } from '../structs/AnchorDescriptor.mjs';
import { BumpTransactionEvent } from '../structs/BumpTransactionEvent.mjs';
import { Event } from '../structs/Event.mjs';
import { Option_EventZ } from '../structs/Option_EventZ.mjs';
import { Result_COption_EventZDecodeErrorZ } from '../structs/Result_COption_EventZDecodeErrorZ.mjs';
import { Bolt11ParseError } from '../structs/Bolt11ParseError.mjs';
import { Result_SiPrefixBolt11ParseErrorZ } from '../structs/Result_SiPrefixBolt11ParseErrorZ.mjs';
import { ParseOrSemanticError } from '../structs/ParseOrSemanticError.mjs';
import { Result_Bolt11InvoiceParseOrSemanticErrorZ } from '../structs/Result_Bolt11InvoiceParseOrSemanticErrorZ.mjs';
import { SignedRawBolt11Invoice } from '../structs/SignedRawBolt11Invoice.mjs';
import { Result_SignedRawBolt11InvoiceBolt11ParseErrorZ } from '../structs/Result_SignedRawBolt11InvoiceBolt11ParseErrorZ.mjs';
import { RawBolt11Invoice } from '../structs/RawBolt11Invoice.mjs';
import { Bolt11InvoiceSignature } from '../structs/Bolt11InvoiceSignature.mjs';
import { ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ } from '../structs/ThreeTuple_RawBolt11Invoice_u832Bolt11InvoiceSignatureZ.mjs';
import { PayeePubKey } from '../structs/PayeePubKey.mjs';
import { Result_PayeePubKeySecp256k1ErrorZ } from '../structs/Result_PayeePubKeySecp256k1ErrorZ.mjs';
import { PrivateRoute } from '../structs/PrivateRoute.mjs';
import { PositiveTimestamp } from '../structs/PositiveTimestamp.mjs';
import { Result_PositiveTimestampCreationErrorZ } from '../structs/Result_PositiveTimestampCreationErrorZ.mjs';
import { Result_NoneBolt11SemanticErrorZ } from '../structs/Result_NoneBolt11SemanticErrorZ.mjs';
import { Result_Bolt11InvoiceBolt11SemanticErrorZ } from '../structs/Result_Bolt11InvoiceBolt11SemanticErrorZ.mjs';
import { Description } from '../structs/Description.mjs';
import { Result_DescriptionCreationErrorZ } from '../structs/Result_DescriptionCreationErrorZ.mjs';
import { Result_PrivateRouteCreationErrorZ } from '../structs/Result_PrivateRouteCreationErrorZ.mjs';
import { Result_OutPointDecodeErrorZ } from '../structs/Result_OutPointDecodeErrorZ.mjs';
import { BigSize } from '../structs/BigSize.mjs';
import { Result_BigSizeDecodeErrorZ } from '../structs/Result_BigSizeDecodeErrorZ.mjs';
import { Result_HostnameDecodeErrorZ } from '../structs/Result_HostnameDecodeErrorZ.mjs';
import { TransactionU16LenLimited } from '../structs/TransactionU16LenLimited.mjs';
import { Result_TransactionU16LenLimitedNoneZ } from '../structs/Result_TransactionU16LenLimitedNoneZ.mjs';
import { Result_TransactionU16LenLimitedDecodeErrorZ } from '../structs/Result_TransactionU16LenLimitedDecodeErrorZ.mjs';
import { Result_UntrustedStringDecodeErrorZ } from '../structs/Result_UntrustedStringDecodeErrorZ.mjs';
import { ReceiveTlvs } from '../structs/ReceiveTlvs.mjs';
import { Result_ReceiveTlvsDecodeErrorZ } from '../structs/Result_ReceiveTlvsDecodeErrorZ.mjs';
import { PaymentRelay } from '../structs/PaymentRelay.mjs';
import { Result_PaymentRelayDecodeErrorZ } from '../structs/Result_PaymentRelayDecodeErrorZ.mjs';
import { PaymentConstraints } from '../structs/PaymentConstraints.mjs';
import { Result_PaymentConstraintsDecodeErrorZ } from '../structs/Result_PaymentConstraintsDecodeErrorZ.mjs';
import { PaymentError } from '../structs/PaymentError.mjs';
import { Result_ThirtyTwoBytesPaymentErrorZ } from '../structs/Result_ThirtyTwoBytesPaymentErrorZ.mjs';
import { Result_NonePaymentErrorZ } from '../structs/Result_NonePaymentErrorZ.mjs';
import { ProbingError } from '../structs/ProbingError.mjs';
import { Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbingErrorZ } from '../structs/Result_CVec_C2Tuple_ThirtyTwoBytesThirtyTwoBytesZZProbingErrorZ.mjs';
import { Result_StrSecp256k1ErrorZ } from '../structs/Result_StrSecp256k1ErrorZ.mjs';
import { OnionMessagePath } from '../structs/OnionMessagePath.mjs';
import { Result_OnionMessagePathNoneZ } from '../structs/Result_OnionMessagePathNoneZ.mjs';
import { TwoTuple_PublicKeyOnionMessageZ } from '../structs/TwoTuple_PublicKeyOnionMessageZ.mjs';
import { SendError } from '../structs/SendError.mjs';
import { Result_C2Tuple_PublicKeyOnionMessageZSendErrorZ } from '../structs/Result_C2Tuple_PublicKeyOnionMessageZSendErrorZ.mjs';
import { ParsedOnionMessageContents } from '../structs/ParsedOnionMessageContents.mjs';
import { PeeledOnion } from '../structs/PeeledOnion.mjs';
import { Result_PeeledOnionNoneZ } from '../structs/Result_PeeledOnionNoneZ.mjs';
import { Result_NoneSendErrorZ } from '../structs/Result_NoneSendErrorZ.mjs';
import { Result_BlindedPathNoneZ } from '../structs/Result_BlindedPathNoneZ.mjs';
import { Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ } from '../structs/Result_C2Tuple_BlindedPayInfoBlindedPathZNoneZ.mjs';
import { Result_BlindedPathDecodeErrorZ } from '../structs/Result_BlindedPathDecodeErrorZ.mjs';
import { Result_BlindedHopDecodeErrorZ } from '../structs/Result_BlindedHopDecodeErrorZ.mjs';
import { Result_InvoiceErrorDecodeErrorZ } from '../structs/Result_InvoiceErrorDecodeErrorZ.mjs';
import { WatchedOutput } from '../structs/WatchedOutput.mjs';
import { Filter, FilterInterface } from '../structs/Filter.mjs';
import { Option_FilterZ } from '../structs/Option_FilterZ.mjs';
import { LockedChannelMonitor } from '../structs/LockedChannelMonitor.mjs';
import { Result_LockedChannelMonitorNoneZ } from '../structs/Result_LockedChannelMonitorNoneZ.mjs';
import { MonitorUpdateId } from '../structs/MonitorUpdateId.mjs';
import { TwoTuple_OutPointCVec_MonitorUpdateIdZZ } from '../structs/TwoTuple_OutPointCVec_MonitorUpdateIdZZ.mjs';
import { KVStore, KVStoreInterface } from '../structs/KVStore.mjs';
import { ChannelUsage } from '../structs/ChannelUsage.mjs';
import { ProbabilisticScoringFeeParameters } from '../structs/ProbabilisticScoringFeeParameters.mjs';
import { ScoreLookUp, ScoreLookUpInterface } from '../structs/ScoreLookUp.mjs';
import { ScoreUpdate, ScoreUpdateInterface } from '../structs/ScoreUpdate.mjs';
import { LockableScore, LockableScoreInterface } from '../structs/LockableScore.mjs';
import { WriteableScore, WriteableScoreInterface } from '../structs/WriteableScore.mjs';
import { Persister, PersisterInterface } from '../structs/Persister.mjs';
import { MonitorUpdatingPersister } from '../structs/MonitorUpdatingPersister.mjs';
import { Persist, PersistInterface } from '../structs/Persist.mjs';
import { PrintableString } from '../structs/PrintableString.mjs';
import { FutureCallback, FutureCallbackInterface } from '../structs/FutureCallback.mjs';
import { Future } from '../structs/Future.mjs';
import { ChannelHandshakeConfig } from '../structs/ChannelHandshakeConfig.mjs';
import { ChannelHandshakeLimits } from '../structs/ChannelHandshakeLimits.mjs';
import { ChannelConfigUpdate } from '../structs/ChannelConfigUpdate.mjs';
import { UserConfig } from '../structs/UserConfig.mjs';
import { BestBlock } from '../structs/BestBlock.mjs';
import { Listen, ListenInterface } from '../structs/Listen.mjs';
import { Confirm, ConfirmInterface } from '../structs/Confirm.mjs';
import { ChainMonitor } from '../structs/ChainMonitor.mjs';
import { EventHandler, EventHandlerInterface } from '../structs/EventHandler.mjs';
import { EventsProvider, EventsProviderInterface } from '../structs/EventsProvider.mjs';
import { FailureCode } from '../structs/FailureCode.mjs';
import { ChainParameters } from '../structs/ChainParameters.mjs';
import { MessageSendEventsProvider, MessageSendEventsProviderInterface } from '../structs/MessageSendEventsProvider.mjs';
import { ChannelMessageHandler, ChannelMessageHandlerInterface } from '../structs/ChannelMessageHandler.mjs';
import { OffersMessageHandler, OffersMessageHandlerInterface } from '../structs/OffersMessageHandler.mjs';
import { ChannelManagerReadArgs } from '../structs/ChannelManagerReadArgs.mjs';
import { ExpandedKey } from '../structs/ExpandedKey.mjs';
import { Packet } from '../structs/Packet.mjs';
import { RoutingMessageHandler, RoutingMessageHandlerInterface } from '../structs/RoutingMessageHandler.mjs';
import { OnionMessageHandler, OnionMessageHandlerInterface } from '../structs/OnionMessageHandler.mjs';
import { CustomMessageReader, CustomMessageReaderInterface } from '../structs/CustomMessageReader.mjs';
import { CustomMessageHandler, CustomMessageHandlerInterface } from '../structs/CustomMessageHandler.mjs';
import { IgnoringMessageHandler } from '../structs/IgnoringMessageHandler.mjs';
import { CustomOnionMessageHandler, CustomOnionMessageHandlerInterface } from '../structs/CustomOnionMessageHandler.mjs';
import { ErroringMessageHandler } from '../structs/ErroringMessageHandler.mjs';
import { MessageHandler } from '../structs/MessageHandler.mjs';
import { SocketDescriptor, SocketDescriptorInterface } from '../structs/SocketDescriptor.mjs';
import { PeerManager } from '../structs/PeerManager.mjs';
import { DirectedChannelTransactionParameters } from '../structs/DirectedChannelTransactionParameters.mjs';
import { OfferFeatures } from '../structs/OfferFeatures.mjs';
import { InvoiceRequestFeatures } from '../structs/InvoiceRequestFeatures.mjs';
import { Amount } from '../structs/Amount.mjs';
import { Quantity } from '../structs/Quantity.mjs';
import { TaggedHash } from '../structs/TaggedHash.mjs';
import { ErroneousField } from '../structs/ErroneousField.mjs';
import { P2PGossipSync } from '../structs/P2PGossipSync.mjs';
import { ReadOnlyNetworkGraph } from '../structs/ReadOnlyNetworkGraph.mjs';
import { DirectedChannelInfo } from '../structs/DirectedChannelInfo.mjs';
import { EffectiveCapacity } from '../structs/EffectiveCapacity.mjs';
import { DefaultRouter } from '../structs/DefaultRouter.mjs';
import { ScorerAccountingForInFlightHtlcs } from '../structs/ScorerAccountingForInFlightHtlcs.mjs';
import { Payee } from '../structs/Payee.mjs';
import { Score, ScoreInterface } from '../structs/Score.mjs';
import { MultiThreadedLockableScore } from '../structs/MultiThreadedLockableScore.mjs';
import { MultiThreadedScoreLockRead } from '../structs/MultiThreadedScoreLockRead.mjs';
import { MultiThreadedScoreLockWrite } from '../structs/MultiThreadedScoreLockWrite.mjs';
import { ProbabilisticScoringDecayParameters } from '../structs/ProbabilisticScoringDecayParameters.mjs';
import { KeysManager } from '../structs/KeysManager.mjs';
import { PhantomKeysManager } from '../structs/PhantomKeysManager.mjs';
import { MessageRouter, MessageRouterInterface } from '../structs/MessageRouter.mjs';
import { OnionMessenger } from '../structs/OnionMessenger.mjs';
import { DefaultMessageRouter } from '../structs/DefaultMessageRouter.mjs';
import { ForwardNode } from '../structs/ForwardNode.mjs';
import { ForwardTlvs } from '../structs/ForwardTlvs.mjs';
import { CoinSelectionSource, CoinSelectionSourceInterface } from '../structs/CoinSelectionSource.mjs';
import { WalletSource, WalletSourceInterface } from '../structs/WalletSource.mjs';
import { Wallet } from '../structs/Wallet.mjs';
import { BumpTransactionEventHandler } from '../structs/BumpTransactionEventHandler.mjs';
import { RapidGossipSync } from '../structs/RapidGossipSync.mjs';
import { GossipSync } from '../structs/GossipSync.mjs';
import { RawDataPart } from '../structs/RawDataPart.mjs';
import { Sha256 } from '../structs/Sha256.mjs';
import { ExpiryTime } from '../structs/ExpiryTime.mjs';
import { MinFinalCltvExpiryDelta } from '../structs/MinFinalCltvExpiryDelta.mjs';
import { Fallback } from '../structs/Fallback.mjs';


import { CommonBase, UInt5, WitnessVersion, UnqualifiedError } from './CommonBase.mjs';
import * as bindings from '../bindings.mjs'



/** An implementation of EcdsaChannelSigner */
export interface EcdsaChannelSignerInterface {
	/**Create a signature for a counterparty's commitment transaction and associated HTLC transactions.
	 * 
	 * Note that if signing fails or is rejected, the channel will be force-closed.
	 * 
	 * Policy checks should be implemented in this function, including checking the amount
	 * sent to us and checking the HTLCs.
	 * 
	 * The preimages of outgoing HTLCs that were fulfilled since the last commitment are provided.
	 * A validating signer should ensure that an HTLC output is removed only when the matching
	 * preimage is provided, or when the value to holder is restored.
	 * 
	 * Note that all the relevant preimages will be provided, but there may also be additional
	 * irrelevant or duplicate preimages.
	 */
	sign_counterparty_commitment(commitment_tx: CommitmentTransaction, preimages: Uint8Array[]): Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ;
	/**Validate the counterparty's revocation.
	 * 
	 * This is required in order for the signer to make sure that the state has moved
	 * forward and it is safe to sign the next counterparty commitment.
	 */
	validate_counterparty_revocation(idx: bigint, secret: Uint8Array): Result_NoneNoneZ;
	/**Creates a signature for a holder's commitment transaction.
	 * 
	 * This will be called
	 * - with a non-revoked `commitment_tx`.
	 * - with the latest `commitment_tx` when we initiate a force-close.
	 * 
	 * This may be called multiple times for the same transaction.
	 * 
	 * An external signer implementation should check that the commitment has not been revoked.
	 */
	sign_holder_commitment(commitment_tx: HolderCommitmentTransaction): Result_ECDSASignatureNoneZ;
	/**Create a signature for the given input in a transaction spending an HTLC transaction output
	 * or a commitment transaction `to_local` output when our counterparty broadcasts an old state.
	 * 
	 * A justice transaction may claim multiple outputs at the same time if timelocks are
	 * similar, but only a signature for the input at index `input` should be signed for here.
	 * It may be called multiple times for same output(s) if a fee-bump is needed with regards
	 * to an upcoming timelock expiration.
	 * 
	 * Amount is value of the output spent by this input, committed to in the BIP 143 signature.
	 * 
	 * `per_commitment_key` is revocation secret which was provided by our counterparty when they
	 * revoked the state which they eventually broadcast. It's not a _holder_ secret key and does
	 * not allow the spending of any funds by itself (you need our holder `revocation_secret` to do
	 * so).
	 */
	sign_justice_revoked_output(justice_tx: Uint8Array, input: number, amount: bigint, per_commitment_key: Uint8Array): Result_ECDSASignatureNoneZ;
	/**Create a signature for the given input in a transaction spending a commitment transaction
	 * HTLC output when our counterparty broadcasts an old state.
	 * 
	 * A justice transaction may claim multiple outputs at the same time if timelocks are
	 * similar, but only a signature for the input at index `input` should be signed for here.
	 * It may be called multiple times for same output(s) if a fee-bump is needed with regards
	 * to an upcoming timelock expiration.
	 * 
	 * `amount` is the value of the output spent by this input, committed to in the BIP 143
	 * signature.
	 * 
	 * `per_commitment_key` is revocation secret which was provided by our counterparty when they
	 * revoked the state which they eventually broadcast. It's not a _holder_ secret key and does
	 * not allow the spending of any funds by itself (you need our holder revocation_secret to do
	 * so).
	 * 
	 * `htlc` holds HTLC elements (hash, timelock), thus changing the format of the witness script
	 * (which is committed to in the BIP 143 signatures).
	 */
	sign_justice_revoked_htlc(justice_tx: Uint8Array, input: number, amount: bigint, per_commitment_key: Uint8Array, htlc: HTLCOutputInCommitment): Result_ECDSASignatureNoneZ;
	/**Computes the signature for a commitment transaction's HTLC output used as an input within
	 * `htlc_tx`, which spends the commitment transaction at index `input`. The signature returned
	 * must be be computed using [`EcdsaSighashType::All`].
	 * 
	 * Note that this may be called for HTLCs in the penultimate commitment transaction if a
	 * [`ChannelMonitor`] [replica](https://github.com/lightningdevkit/rust-lightning/blob/main/GLOSSARY.md#monitor-replicas)
	 * broadcasts it before receiving the update for the latest commitment transaction.
	 * 
	 * [`EcdsaSighashType::All`]: bitcoin::blockdata::transaction::EcdsaSighashType::All
	 * [`ChannelMonitor`]: crate::chain::channelmonitor::ChannelMonitor
	 */
	sign_holder_htlc_transaction(htlc_tx: Uint8Array, input: number, htlc_descriptor: HTLCDescriptor): Result_ECDSASignatureNoneZ;
	/**Create a signature for a claiming transaction for a HTLC output on a counterparty's commitment
	 * transaction, either offered or received.
	 * 
	 * Such a transaction may claim multiples offered outputs at same time if we know the
	 * preimage for each when we create it, but only the input at index `input` should be
	 * signed for here. It may be called multiple times for same output(s) if a fee-bump is
	 * needed with regards to an upcoming timelock expiration.
	 * 
	 * `witness_script` is either an offered or received script as defined in BOLT3 for HTLC
	 * outputs.
	 * 
	 * `amount` is value of the output spent by this input, committed to in the BIP 143 signature.
	 * 
	 * `per_commitment_point` is the dynamic point corresponding to the channel state
	 * detected onchain. It has been generated by our counterparty and is used to derive
	 * channel state keys, which are then included in the witness script and committed to in the
	 * BIP 143 signature.
	 */
	sign_counterparty_htlc_transaction(htlc_tx: Uint8Array, input: number, amount: bigint, per_commitment_point: Uint8Array, htlc: HTLCOutputInCommitment): Result_ECDSASignatureNoneZ;
	/**Create a signature for a (proposed) closing transaction.
	 * 
	 * Note that, due to rounding, there may be one \"missing\" satoshi, and either party may have
	 * chosen to forgo their output as dust.
	 */
	sign_closing_transaction(closing_tx: ClosingTransaction): Result_ECDSASignatureNoneZ;
	/**Computes the signature for a commitment transaction's anchor output used as an
	 * input within `anchor_tx`, which spends the commitment transaction, at index `input`.
	 */
	sign_holder_anchor_input(anchor_tx: Uint8Array, input: number): Result_ECDSASignatureNoneZ;
	/**Signs a channel announcement message with our funding key proving it comes from one of the
	 * channel participants.
	 * 
	 * Channel announcements also require a signature from each node's network key. Our node
	 * signature is computed through [`NodeSigner::sign_gossip_message`].
	 * 
	 * Note that if this fails or is rejected, the channel will not be publicly announced and
	 * our counterparty may (though likely will not) close the channel on us for violating the
	 * protocol.
	 */
	sign_channel_announcement_with_funding_key(msg: UnsignedChannelAnnouncement): Result_ECDSASignatureNoneZ;
}

class LDKEcdsaChannelSignerHolder {
	held: EcdsaChannelSigner|null = null;
}

/**
 * A trait to sign Lightning channel transactions as described in
 * [BOLT 3](https://github.com/lightning/bolts/blob/master/03-transactions.md).
 * 
 * Signing services could be implemented on a hardware wallet and should implement signing
 * policies in order to be secure. Please refer to the [VLS Policy
 * Controls](https://gitlab.com/lightning-signer/validating-lightning-signer/-/blob/main/docs/policy-controls.md)
 * for an example of such policies.
 */
export class EcdsaChannelSigner extends CommonBase {
	/* @internal */
	public bindings_instance: bindings.LDKEcdsaChannelSigner|null;

	/* @internal */
	public instance_idx?: number;

	/* @internal */
	constructor(_dummy: null, ptr: bigint) {
		super(ptr, bindings.EcdsaChannelSigner_free);
		this.bindings_instance = null;
	}

	/** Creates a new instance of EcdsaChannelSigner from a given implementation */
	public static new_impl(arg: EcdsaChannelSignerInterface, channelSigner_impl: ChannelSignerInterface, pubkeys: ChannelPublicKeys): EcdsaChannelSigner {
		const impl_holder: LDKEcdsaChannelSignerHolder = new LDKEcdsaChannelSignerHolder();
		let structImplementation = {
			sign_counterparty_commitment (commitment_tx: bigint, preimages: number): bigint {
				const commitment_tx_hu_conv: CommitmentTransaction = new CommitmentTransaction(null, commitment_tx);
				const preimages_conv_12_len: number = bindings.getArrayLength(preimages);
				const preimages_conv_12_arr: Uint8Array[] = new Array(preimages_conv_12_len).fill(null);
				for (var m = 0; m < preimages_conv_12_len; m++) {
					const preimages_conv_12: number = bindings.getU32ArrayElem(preimages, m);
					const preimages_conv_12_conv: Uint8Array = bindings.decodeUint8Array(preimages_conv_12);
					preimages_conv_12_arr[m] = preimages_conv_12_conv;
				}
				bindings.freeWasmMemory(preimages)
				const ret: Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ = arg.sign_counterparty_commitment(commitment_tx_hu_conv, preimages_conv_12_arr);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			validate_counterparty_revocation (idx: bigint, secret: number): bigint {
				const secret_conv: Uint8Array = bindings.decodeUint8Array(secret);
				const ret: Result_NoneNoneZ = arg.validate_counterparty_revocation(idx, secret_conv);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			sign_holder_commitment (commitment_tx: bigint): bigint {
				const commitment_tx_hu_conv: HolderCommitmentTransaction = new HolderCommitmentTransaction(null, commitment_tx);
				const ret: Result_ECDSASignatureNoneZ = arg.sign_holder_commitment(commitment_tx_hu_conv);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			sign_justice_revoked_output (justice_tx: number, input: number, amount: bigint, per_commitment_key: number): bigint {
				const justice_tx_conv: Uint8Array = bindings.decodeUint8Array(justice_tx);
				const per_commitment_key_conv: Uint8Array = bindings.decodeUint8Array(per_commitment_key);
				const ret: Result_ECDSASignatureNoneZ = arg.sign_justice_revoked_output(justice_tx_conv, input, amount, per_commitment_key_conv);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			sign_justice_revoked_htlc (justice_tx: number, input: number, amount: bigint, per_commitment_key: number, htlc: bigint): bigint {
				const justice_tx_conv: Uint8Array = bindings.decodeUint8Array(justice_tx);
				const per_commitment_key_conv: Uint8Array = bindings.decodeUint8Array(per_commitment_key);
				const htlc_hu_conv: HTLCOutputInCommitment = new HTLCOutputInCommitment(null, htlc);
				const ret: Result_ECDSASignatureNoneZ = arg.sign_justice_revoked_htlc(justice_tx_conv, input, amount, per_commitment_key_conv, htlc_hu_conv);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			sign_holder_htlc_transaction (htlc_tx: number, input: number, htlc_descriptor: bigint): bigint {
				const htlc_tx_conv: Uint8Array = bindings.decodeUint8Array(htlc_tx);
				const htlc_descriptor_hu_conv: HTLCDescriptor = new HTLCDescriptor(null, htlc_descriptor);
				const ret: Result_ECDSASignatureNoneZ = arg.sign_holder_htlc_transaction(htlc_tx_conv, input, htlc_descriptor_hu_conv);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			sign_counterparty_htlc_transaction (htlc_tx: number, input: number, amount: bigint, per_commitment_point: number, htlc: bigint): bigint {
				const htlc_tx_conv: Uint8Array = bindings.decodeUint8Array(htlc_tx);
				const per_commitment_point_conv: Uint8Array = bindings.decodeUint8Array(per_commitment_point);
				const htlc_hu_conv: HTLCOutputInCommitment = new HTLCOutputInCommitment(null, htlc);
				const ret: Result_ECDSASignatureNoneZ = arg.sign_counterparty_htlc_transaction(htlc_tx_conv, input, amount, per_commitment_point_conv, htlc_hu_conv);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			sign_closing_transaction (closing_tx: bigint): bigint {
				const closing_tx_hu_conv: ClosingTransaction = new ClosingTransaction(null, closing_tx);
				const ret: Result_ECDSASignatureNoneZ = arg.sign_closing_transaction(closing_tx_hu_conv);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			sign_holder_anchor_input (anchor_tx: number, input: number): bigint {
				const anchor_tx_conv: Uint8Array = bindings.decodeUint8Array(anchor_tx);
				const ret: Result_ECDSASignatureNoneZ = arg.sign_holder_anchor_input(anchor_tx_conv, input);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
			sign_channel_announcement_with_funding_key (msg: bigint): bigint {
				const msg_hu_conv: UnsignedChannelAnnouncement = new UnsignedChannelAnnouncement(null, msg);
				const ret: Result_ECDSASignatureNoneZ = arg.sign_channel_announcement_with_funding_key(msg_hu_conv);
				const result: bigint = ret == null ? 0n : ret.clone_ptr();
				return result;
			},
		} as bindings.LDKEcdsaChannelSigner;
		const channelSigner = ChannelSigner.new_impl(channelSigner_impl, pubkeys);
		const ptr_idx: [bigint, number] = bindings.LDKEcdsaChannelSigner_new(structImplementation, channelSigner.instance_idx!, pubkeys == null ? 0n : pubkeys.clone_ptr());

		impl_holder.held = new EcdsaChannelSigner(null, ptr_idx[0]);
		impl_holder.held.instance_idx = ptr_idx[1];
		impl_holder.held.bindings_instance = structImplementation;
		impl_holder.held.ptrs_to.push(channelSigner);
		return impl_holder.held!;
	}

	/**
	 * Create a signature for a counterparty's commitment transaction and associated HTLC transactions.
	 * 
	 * Note that if signing fails or is rejected, the channel will be force-closed.
	 * 
	 * Policy checks should be implemented in this function, including checking the amount
	 * sent to us and checking the HTLCs.
	 * 
	 * The preimages of outgoing HTLCs that were fulfilled since the last commitment are provided.
	 * A validating signer should ensure that an HTLC output is removed only when the matching
	 * preimage is provided, or when the value to holder is restored.
	 * 
	 * Note that all the relevant preimages will be provided, but there may also be additional
	 * irrelevant or duplicate preimages.
	 */
	public sign_counterparty_commitment(commitment_tx: CommitmentTransaction, preimages: Uint8Array[]): Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_counterparty_commitment(this.ptr, commitment_tx == null ? 0n : CommonBase.get_ptr_of(commitment_tx), bindings.encodeUint32Array(preimages.map(preimages_conv_12 => bindings.encodeUint8Array(bindings.check_arr_len(preimages_conv_12, 32)))));
		const ret_hu_conv: Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ = Result_C2Tuple_ECDSASignatureCVec_ECDSASignatureZZNoneZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, commitment_tx);
		return ret_hu_conv;
	}

	/**
	 * Validate the counterparty's revocation.
	 * 
	 * This is required in order for the signer to make sure that the state has moved
	 * forward and it is safe to sign the next counterparty commitment.
	 */
	public validate_counterparty_revocation(idx: bigint, secret: Uint8Array): Result_NoneNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_validate_counterparty_revocation(this.ptr, idx, bindings.encodeUint8Array(bindings.check_arr_len(secret, 32)));
		const ret_hu_conv: Result_NoneNoneZ = Result_NoneNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Creates a signature for a holder's commitment transaction.
	 * 
	 * This will be called
	 * - with a non-revoked `commitment_tx`.
	 * - with the latest `commitment_tx` when we initiate a force-close.
	 * 
	 * This may be called multiple times for the same transaction.
	 * 
	 * An external signer implementation should check that the commitment has not been revoked.
	 */
	public sign_holder_commitment(commitment_tx: HolderCommitmentTransaction): Result_ECDSASignatureNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_holder_commitment(this.ptr, commitment_tx == null ? 0n : CommonBase.get_ptr_of(commitment_tx));
		const ret_hu_conv: Result_ECDSASignatureNoneZ = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, commitment_tx);
		return ret_hu_conv;
	}

	/**
	 * Create a signature for the given input in a transaction spending an HTLC transaction output
	 * or a commitment transaction `to_local` output when our counterparty broadcasts an old state.
	 * 
	 * A justice transaction may claim multiple outputs at the same time if timelocks are
	 * similar, but only a signature for the input at index `input` should be signed for here.
	 * It may be called multiple times for same output(s) if a fee-bump is needed with regards
	 * to an upcoming timelock expiration.
	 * 
	 * Amount is value of the output spent by this input, committed to in the BIP 143 signature.
	 * 
	 * `per_commitment_key` is revocation secret which was provided by our counterparty when they
	 * revoked the state which they eventually broadcast. It's not a _holder_ secret key and does
	 * not allow the spending of any funds by itself (you need our holder `revocation_secret` to do
	 * so).
	 */
	public sign_justice_revoked_output(justice_tx: Uint8Array, input: number, amount: bigint, per_commitment_key: Uint8Array): Result_ECDSASignatureNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_justice_revoked_output(this.ptr, bindings.encodeUint8Array(justice_tx), input, amount, bindings.encodeUint8Array(bindings.check_arr_len(per_commitment_key, 32)));
		const ret_hu_conv: Result_ECDSASignatureNoneZ = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Create a signature for the given input in a transaction spending a commitment transaction
	 * HTLC output when our counterparty broadcasts an old state.
	 * 
	 * A justice transaction may claim multiple outputs at the same time if timelocks are
	 * similar, but only a signature for the input at index `input` should be signed for here.
	 * It may be called multiple times for same output(s) if a fee-bump is needed with regards
	 * to an upcoming timelock expiration.
	 * 
	 * `amount` is the value of the output spent by this input, committed to in the BIP 143
	 * signature.
	 * 
	 * `per_commitment_key` is revocation secret which was provided by our counterparty when they
	 * revoked the state which they eventually broadcast. It's not a _holder_ secret key and does
	 * not allow the spending of any funds by itself (you need our holder revocation_secret to do
	 * so).
	 * 
	 * `htlc` holds HTLC elements (hash, timelock), thus changing the format of the witness script
	 * (which is committed to in the BIP 143 signatures).
	 */
	public sign_justice_revoked_htlc(justice_tx: Uint8Array, input: number, amount: bigint, per_commitment_key: Uint8Array, htlc: HTLCOutputInCommitment): Result_ECDSASignatureNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_justice_revoked_htlc(this.ptr, bindings.encodeUint8Array(justice_tx), input, amount, bindings.encodeUint8Array(bindings.check_arr_len(per_commitment_key, 32)), htlc == null ? 0n : CommonBase.get_ptr_of(htlc));
		const ret_hu_conv: Result_ECDSASignatureNoneZ = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, htlc);
		return ret_hu_conv;
	}

	/**
	 * Computes the signature for a commitment transaction's HTLC output used as an input within
	 * `htlc_tx`, which spends the commitment transaction at index `input`. The signature returned
	 * must be be computed using [`EcdsaSighashType::All`].
	 * 
	 * Note that this may be called for HTLCs in the penultimate commitment transaction if a
	 * [`ChannelMonitor`] [replica](https://github.com/lightningdevkit/rust-lightning/blob/main/GLOSSARY.md#monitor-replicas)
	 * broadcasts it before receiving the update for the latest commitment transaction.
	 * 
	 * [`EcdsaSighashType::All`]: bitcoin::blockdata::transaction::EcdsaSighashType::All
	 * [`ChannelMonitor`]: crate::chain::channelmonitor::ChannelMonitor
	 */
	public sign_holder_htlc_transaction(htlc_tx: Uint8Array, input: number, htlc_descriptor: HTLCDescriptor): Result_ECDSASignatureNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_holder_htlc_transaction(this.ptr, bindings.encodeUint8Array(htlc_tx), input, htlc_descriptor == null ? 0n : CommonBase.get_ptr_of(htlc_descriptor));
		const ret_hu_conv: Result_ECDSASignatureNoneZ = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, htlc_descriptor);
		return ret_hu_conv;
	}

	/**
	 * Create a signature for a claiming transaction for a HTLC output on a counterparty's commitment
	 * transaction, either offered or received.
	 * 
	 * Such a transaction may claim multiples offered outputs at same time if we know the
	 * preimage for each when we create it, but only the input at index `input` should be
	 * signed for here. It may be called multiple times for same output(s) if a fee-bump is
	 * needed with regards to an upcoming timelock expiration.
	 * 
	 * `witness_script` is either an offered or received script as defined in BOLT3 for HTLC
	 * outputs.
	 * 
	 * `amount` is value of the output spent by this input, committed to in the BIP 143 signature.
	 * 
	 * `per_commitment_point` is the dynamic point corresponding to the channel state
	 * detected onchain. It has been generated by our counterparty and is used to derive
	 * channel state keys, which are then included in the witness script and committed to in the
	 * BIP 143 signature.
	 */
	public sign_counterparty_htlc_transaction(htlc_tx: Uint8Array, input: number, amount: bigint, per_commitment_point: Uint8Array, htlc: HTLCOutputInCommitment): Result_ECDSASignatureNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_counterparty_htlc_transaction(this.ptr, bindings.encodeUint8Array(htlc_tx), input, amount, bindings.encodeUint8Array(bindings.check_arr_len(per_commitment_point, 33)), htlc == null ? 0n : CommonBase.get_ptr_of(htlc));
		const ret_hu_conv: Result_ECDSASignatureNoneZ = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, htlc);
		return ret_hu_conv;
	}

	/**
	 * Create a signature for a (proposed) closing transaction.
	 * 
	 * Note that, due to rounding, there may be one \"missing\" satoshi, and either party may have
	 * chosen to forgo their output as dust.
	 */
	public sign_closing_transaction(closing_tx: ClosingTransaction): Result_ECDSASignatureNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_closing_transaction(this.ptr, closing_tx == null ? 0n : CommonBase.get_ptr_of(closing_tx));
		const ret_hu_conv: Result_ECDSASignatureNoneZ = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, closing_tx);
		return ret_hu_conv;
	}

	/**
	 * Computes the signature for a commitment transaction's anchor output used as an
	 * input within `anchor_tx`, which spends the commitment transaction, at index `input`.
	 */
	public sign_holder_anchor_input(anchor_tx: Uint8Array, input: number): Result_ECDSASignatureNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_holder_anchor_input(this.ptr, bindings.encodeUint8Array(anchor_tx), input);
		const ret_hu_conv: Result_ECDSASignatureNoneZ = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		return ret_hu_conv;
	}

	/**
	 * Signs a channel announcement message with our funding key proving it comes from one of the
	 * channel participants.
	 * 
	 * Channel announcements also require a signature from each node's network key. Our node
	 * signature is computed through [`NodeSigner::sign_gossip_message`].
	 * 
	 * Note that if this fails or is rejected, the channel will not be publicly announced and
	 * our counterparty may (though likely will not) close the channel on us for violating the
	 * protocol.
	 */
	public sign_channel_announcement_with_funding_key(msg: UnsignedChannelAnnouncement): Result_ECDSASignatureNoneZ {
		const ret: bigint = bindings.EcdsaChannelSigner_sign_channel_announcement_with_funding_key(this.ptr, msg == null ? 0n : CommonBase.get_ptr_of(msg));
		const ret_hu_conv: Result_ECDSASignatureNoneZ = Result_ECDSASignatureNoneZ.constr_from_ptr(ret);
		CommonBase.add_ref_from(this, msg);
		return ret_hu_conv;
	}

}