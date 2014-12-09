using System;
using TradingApi.ModelObjects;

namespace Cob.TradingApps.BtcData.Exchanges
{
   interface IExchangeInfo
   {
      BtcMarketData MarketData { get; set; }
      BtcInfo.ExchangeEnum Exchange { get; set; }
      String BaseJsonUrl { get; set; }
      
   }
}
