using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using Cob.TradingApps.BtcData.Exchanges;
using TradingApi.ModelObjects;

namespace Cob.TradingApps.BtcData
{
    public sealed class ExchangeConnectivity
    {
       private static volatile ExchangeConnectivity _instance = null;
       private static readonly object _lock = new object();

       private Dictionary<BtcInfo.ExchangeEnum, ExchangeBase> _exchanges;
       public Dictionary<BtcInfo.ExchangeEnum, ExchangeBase> Exchanges { get { return _exchanges; }} 

       private ConcurrentQueue<ExchangeBase> _exchangeUpdateQueue;

       public event MarketDataUpdateHandler MarketDataUpdate;
       public delegate void MarketDataUpdateHandler(ExchangeBase exchangeBase);

       public ConcurrentDictionary<BtcInfo.ExchangeEnum, BtcMarketData> LastExchangeMarketData { get; set; }

       private BtcInfo.PairTypeEnum _pairType;
       public BtcInfo.PairTypeEnum PairType { get { return _pairType; }}

       public static ExchangeConnectivity Instance
       {
          get
          {
             if (_instance == null)
             {
                lock (_lock)
                {
                   if (_instance == null)
                   {
                      _instance = new ExchangeConnectivity();
                   }
                }
             }
             return _instance;
          }
       }

       public void Initialize()
       {
          try
          {
             _exchanges = new Dictionary<BtcInfo.ExchangeEnum, ExchangeBase>();
             LastExchangeMarketData = new ConcurrentDictionary<BtcInfo.ExchangeEnum, BtcMarketData>();
             _exchangeUpdateQueue = new ConcurrentQueue<ExchangeBase>();

             var exchanges = Enum.GetValues(typeof (BtcInfo.ExchangeEnum));
             foreach (BtcInfo.ExchangeEnum exchange in exchanges)
             {
                var exchangeConnection = new BitfinexExchange();
                exchangeConnection.ConnectToApi();
                _exchanges.Add(exchange, exchangeConnection);
                var bw = new BackgroundWorker();
                bw.DoWork += BwOnDoWork;
                bw.WorkerSupportsCancellation = true;
                bw.RunWorkerCompleted += BwOnRunWorkerCompleted;
                bw.RunWorkerAsync(exchange);
             }
             ThreadPool.QueueUserWorkItem(ProcessExchangeUpdate);
          }
          catch (Exception ex)
          {
             Logger.LogException(ex);
          }
       }

       public void SetGlobalPairType(BtcInfo.PairTypeEnum pairType)
       {
          lock (_lock)
          {
             _pairType = pairType;
          }
       }

       private void BwOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
       {
          var btcExchangeEnum = doWorkEventArgs.Argument is BtcInfo.ExchangeEnum
             ? (BtcInfo.ExchangeEnum) doWorkEventArgs.Argument
             : 0;
          while (true)
          {
             try
             {
                lock (_lock)
                {
                   ExchangeBase exchangeConnectionBase = null;
                   switch (btcExchangeEnum)
                   {
                      case BtcInfo.ExchangeEnum.BITFINEX:
                         exchangeConnectionBase = _exchanges[BtcInfo.ExchangeEnum.BITFINEX];
                         var bfExchange = exchangeConnectionBase as BitfinexExchange;
                         if (bfExchange != null)
                         {
                            bfExchange.ProcessMarketDataUpdate(PairType);
                         }

                         break;
                   }
                   if (exchangeConnectionBase != null)
                   {
                      exchangeConnectionBase.SetBtcMarketData(PairType);
                      _exchangeUpdateQueue.Enqueue(exchangeConnectionBase);
                   }                   
                }
             }
             catch (Exception ex)
             {
                Logger.LogException(ex);
             }
             finally
             {
                Thread.Sleep(10000);
             }
          }
       }

       private void ProcessExchangeUpdate(object state)
       {
          while (true)
          {
             if (_exchangeUpdateQueue.Count == 0)
                Thread.Sleep(2000);

             ExchangeBase exchangeBase = null;
             if (_exchangeUpdateQueue.TryDequeue(out exchangeBase))
             {
                //TODO: pubish event back to main form...
                MarketDataUpdate(exchangeBase);
                LastExchangeMarketData[exchangeBase.Exchange] = exchangeBase.MarketData;
             }
          }
       }

       private void BwOnRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs runWorkerCompletedEventArgs)
       {
       }

    }
}
