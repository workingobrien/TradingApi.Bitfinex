namespace TradingApi.ModelObjects.Bitfinex.Json
{
   public class BitfinexCancelReplaceOrderResponse : BitfinexNewOrderResponse
   {
      public int OriginalOrderId { get; set; }

      public override string ToString()
      {
         var str = string.Format("Cancel Replace (Id: {0}) Symb:{1} {2} Sz:{3} - Px:{4}. Original Order Id: {13} (Type:{5}, IsLive:{6}, Executed Amt:{7} - OrderId: {8})" +
               "(IsCancelled: {9}, WasForced: {10}, RemainingAmount: {11}, ExecutedAmount: {12})",
               Id, Symbol, Side, OriginalAmount, Price, Type, IsLive, ExecutedAmount, OrderId,
               IsCancelled, WasForced, RemainingAmount, ExecutedAmount, OriginalOrderId);
         return str;
      }
   }
}
