using System;

namespace TradingApi.ModelObjects
{
   public sealed class BtcMarketData
   {
      public BtcMarketData()
      {
         _timeStamp = DateTime.Now;
      }

      private readonly DateTime _timeStamp;

      public BtcInfo.PairTypeEnum PairType { get; set; }
      public decimal FairValue { get; set; }
      public decimal BidSz { get; set; }
      public decimal Bid { get; set; }
      public decimal Ask { get; set; }
      public decimal AskSz { get; set;  }
      public decimal Last { get; set; }
   }
}
