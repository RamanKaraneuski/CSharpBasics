using log4net;

namespace TestFramework.Utilities
{
    public static class Logger
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Logger));

        public static void Info(string message)
        {
            Log.Info(message);
        }

        public static void Error(string message, Exception ex)
        {
            Log.Error(message, ex);
        }
    }
}