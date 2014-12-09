using System;
using System.Collections.Generic;
using TradingApi.ModelObjects;
using TradingApi.ModelObjects.Bitfinex.Json;

namespace TradingApi.Bitfinex
{
    public  partial class BitfinexApi
    {
       private void InitializeEvents()
       {
          ErrorMessage += OnErrorMessage;
          OrderBookMsg += OnOrderBookMsg;
          BalanceResponseMsg += OnBalanceResponseMsg;
          MultipleOrderFeedMsg += OnMultipleOrderFeedMsg;
          OrderFeedMsg += OnOrderFeedMsg;
          CancelOrderMsg += OnCancelOrderMsg;
          CancelReplaceFeedMsg += OnCancelReplaceFeedMsg;
          CancelMultipleOrdersMsg += OnCancelMultipleOrdersMsg;
          CancelAllActiveOrdersMsg += OnCancelAllActiveOrdersMsg;
          ActiveOffersMsg += OnActiveOffersMsg;
          HistoryMsg += OnHistoryMsg;
          MyTradesMsg += OnMyTradesMsg;
          MarginInformationMsg += OnMarginInformationMsg;
          ActivePositionssMsg += OnActivePositionssMsg;
          OrderStatusMsg += OnOrderStatusMsg;
          NewOfferStatusMsg += OnNewOfferStatusMsg;
          CancelOfferMsg += OnCancelOfferMsg;
          OfferStatusMsg += OnOfferStatusMsg;
          ActiveCreditsMsg  += OnActiveCreditsMsg;
          ActiveSwapsUsedInMarginMsg += OnActiveSwapsUsedInMarginMsg;
          CloseSwapMsg += OnCloseSwapMsg;
          ClaimPositionMsg += OnClaimPositionMsg;
          LendbookResponseMsg += OnLendbookResponseMsg;
          LendsResponseMsg += OnLendsResponseMsg;
      }

       public event ErrorMessageHandler ErrorMessage;
       public delegate void ErrorMessageHandler(string errorMessage);

       public event OrderBookMsgHandler OrderBookMsg;
       public delegate void OrderBookMsgHandler(BitfinexOrderBookGet marketData);

       public event BalanceResponseMsgHandler BalanceResponseMsg;
       public delegate void BalanceResponseMsgHandler(IList<BitfinexBalanceResponse> balanceResponse);

       public event MultipleOrderFeedMsgHandler MultipleOrderFeedMsg;
       public delegate void MultipleOrderFeedMsgHandler(BitfinexMultipleNewOrderResponse ordersResponse);

       public event OrderFeedMsgHandler OrderFeedMsg;
       public delegate void OrderFeedMsgHandler(BitfinexNewOrderResponse orderResponse);

       public event CancelOrderMsgHandler CancelOrderMsg;
       public delegate void CancelOrderMsgHandler(BitfinexOrderStatusResponse cancelResponse);

       public event CancelReplaceFeedMsgHandler CancelReplaceFeedMsg;
       public delegate void CancelReplaceFeedMsgHandler(BitfinexCancelReplaceOrderResponse cancelReplaceReponse);

       public event CancelMultipleOrdersMsgHandler CancelMultipleOrdersMsg;
       public delegate void CancelMultipleOrdersMsgHandler(string msg);

       public event CancelAllActiveOrdersMsgHandler CancelAllActiveOrdersMsg;
       public delegate void CancelAllActiveOrdersMsgHandler(string msg);

       public event ActiveOrdersMsgHandler ActiveOrdersMsg;
       public delegate void ActiveOrdersMsgHandler(IList<BitfinexMarginPositionResponse> activePositionResponse);

       public event HistoryMsgHandler HistoryMsg;
       public delegate void HistoryMsgHandler(IList<BitfinexHistoryResponse> historyResponse);

       public event MyTradesMsgHandler MyTradesMsg;
       public delegate void MyTradesMsgHandler(IList<BitfinexMyTradesResponse> myTradesResponse);

       public event MarginInformationMsgHandler MarginInformationMsg;
       public delegate void MarginInformationMsgHandler(BitfinexMarginInfoResponse marginInfoResponse);

       public event ActivePositionsMsgHandler ActivePositionssMsg;
       public delegate void ActivePositionsMsgHandler(IList<BitfinexMarginPositionResponse> activePositionResponse);

       public event OrderOrderStatusMsgHandler OrderStatusMsg;
       public delegate void OrderOrderStatusMsgHandler(BitfinexOrderStatusResponse orderStatusResponse);

       public event NewOfferStatusMsgHandler NewOfferStatusMsg;
       public delegate void NewOfferStatusMsgHandler(BitfinexOfferStatusResponse newOfferRespone);

       public event CancelOfferMsgHandler CancelOfferMsg;
       public delegate void CancelOfferMsgHandler(BitfinexOfferStatusResponse cancelOfferResponse);

       public event OfferStatusMsgHandler OfferStatusMsg;
       public delegate void OfferStatusMsgHandler(BitfinexOfferStatusResponse offerStatusResponse);

       public event ActiveOffersMsgHandler ActiveOffersMsg;
       public delegate void ActiveOffersMsgHandler(IList<BitfinexOfferStatusResponse> activeOfferResponse);

       public event ActiveCreditsMsgHandler ActiveCreditsMsg;
       public delegate void ActiveCreditsMsgHandler(IList<BitfinexActiveCreditsResponse> activeCreditsResponse);

       public event ActiveSwapsUsedInMarginMsgHandler ActiveSwapsUsedInMarginMsg;
       public delegate void ActiveSwapsUsedInMarginMsgHandler(IList<BitfinexActiveSwapsInMarginResponse> activeSwapsInMarginResponse);

       public event CloseSwapMsgHandler CloseSwapMsg;
       public delegate void CloseSwapMsgHandler(BitfinexActiveSwapsInMarginResponse closeSwapResponse);

       public event ClaimPositionMsgHandler ClaimPositionMsg;
       public delegate void ClaimPositionMsgHandler(BitfinexMarginPositionResponse claimPosResponse);

       public event LendbookResponseMsgHandler LendbookResponseMsg;
       public delegate void LendbookResponseMsgHandler(BitfinexLendbookResponse lendbookResponse);

       public event LendsResponseMsgHandler LendsResponseMsg;
       public delegate void LendsResponseMsgHandler(IList<BitfinexLendsResponse> lendsResponse);

       private void OnLendsResponseMsg(IList<BitfinexLendsResponse> lendsResponse) { }

       private void OnLendbookResponseMsg(BitfinexLendbookResponse lendbookResponse) { }

       private void OnClaimPositionMsg(BitfinexMarginPositionResponse claimPosResponse) { }

       private void OnCloseSwapMsg(BitfinexActiveSwapsInMarginResponse closeSwapResponse) { }

       private void OnActiveSwapsUsedInMarginMsg(IList<BitfinexActiveSwapsInMarginResponse> activeSwapsInMarginResponse) { }

       private void OnActiveCreditsMsg(IList<BitfinexActiveCreditsResponse> activeCreditsResponse) { }

       private void OnOfferStatusMsg(BitfinexOfferStatusResponse offerStatusResponse) { }

       private void OnCancelOfferMsg(BitfinexOfferStatusResponse cancelOfferResponse) { }

       private void OnNewOfferStatusMsg(BitfinexOfferStatusResponse newOfferRespone) { }

       private void OnOrderStatusMsg(BitfinexOrderStatusResponse orderStatusResponse) { }

       private void OnActivePositionssMsg(IList<BitfinexMarginPositionResponse> activePositionResponse) { }

       private void OnMarginInformationMsg(BitfinexMarginInfoResponse marginInfoResponse) { }

       private void OnMyTradesMsg(IList<BitfinexMyTradesResponse> myTradesResponse) { }

       private void OnHistoryMsg(IList<BitfinexHistoryResponse> historyResponse) { }

       private void OnActiveOffersMsg(IList<BitfinexOfferStatusResponse> activeOfferResponse) { }

       private void OnCancelAllActiveOrdersMsg(string msg) { }

       private void OnCancelMultipleOrdersMsg(string msg) { }

       private void OnCancelReplaceFeedMsg(BitfinexCancelReplaceOrderResponse cancelReplaceReponse) { }

       private void OnCancelOrderMsg(BitfinexOrderStatusResponse cancelResponse) { }

       private void OnOrderFeedMsg(BitfinexNewOrderResponse orderResponse) { }

       private void OnMultipleOrderFeedMsg(BitfinexMultipleNewOrderResponse ordersResponse) { }

       private void OnBalanceResponseMsg(IList<BitfinexBalanceResponse> balanceResponse) { }

       private void OnOrderBookMsg(BitfinexOrderBookGet marketData) { }

       private void OnErrorMessage(string errorMessage) { } 



    }
}
