using System;
using System.Runtime.Remoting.Messaging;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace TradingApi.ModelObjects
{
   public static class Logger
   {
      private static readonly ILog _log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

      public static ILog Log
      {
         get { return _log; }
      }

      public static void LogException(Exception ex)
      {
         _log.Error(ex.Message, ex);
      }
   }
}
