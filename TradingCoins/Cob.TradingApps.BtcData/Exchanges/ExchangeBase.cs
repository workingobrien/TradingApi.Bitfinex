using System;
using RestSharp;
using TradingApi.ModelObjects;

namespace Cob.TradingApps.BtcData.Exchanges
{
   public abstract class ExchangeBase : IExchangeInfo
   {
      public BtcMarketData MarketData { get; set; }
      public BtcInfo.ExchangeEnum Exchange { get; set; }
      public string BaseJsonUrl { get; set; }

      protected ExchangeBase(BtcInfo.ExchangeEnum exchange)
      {
         Exchange = exchange;
         MarketData = new BtcMarketData();
      }

      public abstract void ConnectToApi();
      public abstract void ProcessMarketDataUpdate(BtcInfo.PairTypeEnum pairType);
      public abstract void SetBtcMarketData(BtcInfo.PairTypeEnum pairType);
   }
}
