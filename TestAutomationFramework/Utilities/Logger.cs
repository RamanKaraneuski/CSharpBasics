using log4net;

namespace TestFramework.Utilities
{
    public static class Logger
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(Logger));

        // Метод для логирования информации
        public static void Info(string message)
        {
            Log.Info(message);
        }

        // Метод для логирования ошибок
        public static void Error(string message, Exception ex)
        {
            Log.Error(message, ex);
        }
    }
}