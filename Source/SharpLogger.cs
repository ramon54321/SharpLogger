using System;

namespace SharpLogger
{
    public static class SharpLogger
    {
        private static Printer _printer;
        private static LogLevel _level;
        private static string _filter;

        /**
         * Setters used to set the behaviour parameters of the logger.
         */
        public static void SetPrinter(Printer printer)
        {
            _printer = printer;
        }
        public static void SetLevel(LogLevel level)
        {
            _level = level;
        }
        public static void SetFilter(string filter)
        {
            _filter = filter;
        }

        /**
         * This method is called by the user to log a message.
         * It will only proceed if the requested level is higher than the set level.
         * It will only proceed if the filter is more specific than the set filter.
         */
        public static void Log(LogLevel level, string message, string filter = "General")
        {
            // TODO: Implement Log Logic
        }
    }
}
