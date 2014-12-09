using System;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using TradingApi.Bitfinex;
using TradingApi.ModelObjects;
using TradingApi.ModelObjects.Bitfinex.Json;

namespace Cob.TradingApps.BtcData.Exchanges
{
   public class BitfinexExchange : ExchangeBase
   {
      private const string BaseUrl = @"https://api.bitfinex.com/";

      public BitfinexApi Api { get; set; }
      private BitfinexOrderBookGet _orderBookGet;
      public BitfinexOrderBookGet OrderBook { get { return _orderBookGet; } }

      public BitfinexExchange() : base(BtcInfo.ExchangeEnum.BITFINEX)
      {
         BaseJsonUrl = BaseUrl;
      }

      public override void ConnectToApi()
      {
         try
         {
            var apiSecret = ConfigurationManager.AppSettings["ApiSecret"];
            var apiKey = ConfigurationManager.AppSettings["ApiKey"];

            if (string.IsNullOrEmpty(apiSecret))
               throw new Exception("Missing ApiSecret in App.config");

            if (string.IsNullOrEmpty(apiKey))
               throw new Exception("Missing ApiKey in App.config");

            Api = new BitfinexApi(apiSecret, apiKey);
         }
         catch (Exception ex)
         {
            Logger.LogException(ex);
         }
      }

      public override void ProcessMarketDataUpdate(BtcInfo.PairTypeEnum pairType)
      {
         _orderBookGet = Api.GetOrderBook(pairType);
      }

      public override void SetBtcMarketData(BtcInfo.PairTypeEnum pairType)
      {
         try
         {
            if (_orderBookGet != null)
            {
               this.MarketData.PairType = pairType;
               var topBid = _orderBookGet.Bids.FirstOrDefault();
               var topAsk = _orderBookGet.Asks.FirstOrDefault();

               if (topBid != null)
               {
                  this.MarketData.BidSz = topBid.Amount;
                  this.MarketData.Bid = topBid.Price;
               }

               if (topAsk != null)
               {
                  this.MarketData.AskSz = topAsk.Amount;
                  this.MarketData.Ask = topAsk.Price;
               }
            }
         }
         catch (Exception ex)
         {
            Logger.LogException(ex);
         }
      }
   }
}
