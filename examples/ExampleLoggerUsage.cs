using System;
namespace SharpLogger.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            // -- Set up the printer - View class below for details
            Logger.SetPrinter(new ConsolePrinter());

            // -- Log a trace message
            Logger.Log(LogLevel.L0_Trace, "A trace message.");

            // -- Set display level to info and above
            Logger.SetLevel(LogLevel.L2_Info);

            // -- The trace will not print, however the info and warning will
            Logger.Log(LogLevel.L0_Trace, "Another trace message.");
            Logger.Log(LogLevel.L2_Info, "An info message.");
            Logger.Log(LogLevel.L3_Warning, "A warning message.");

            // -- Set display level back to trace to print all levels
            Logger.SetLevel(LogLevel.L0_Trace);

            /**
             * Let's take a look at filters.
             * The filter system is simple but powerful.
             * You set the logger's filter to the most general form of message you want to see.
             * 
             * Only the logs equally and more specific to Car.Engine will be printed.
             * 
             * NOTE: Filters are NOT case sensitive, however convention follows to use capitals to start.
             */
            Logger.SetFilter("Car.Engine");
            Logger.Log(LogLevel.L0_Trace, "The truck wheels are shaking a little.", "Truck.Wheels");
            Logger.Log(LogLevel.L0_Trace, "The truck engine is working normally.", "Truck.Engine");
            Logger.Log(LogLevel.L0_Trace, "The car engine is working normally.", "Car.Engine");
            Logger.Log(LogLevel.L0_Trace, "The car engine crankshaft is getting old.", "Car.Engine.Crankshaft");
            Logger.Log(LogLevel.L3_Warning, "The car engine crankshaft bearing is to hot!", "Car.Engine.Crankshaft.Temperature");

            /**
             * Without changing the filter, note that messages without any filter will be ignored.
             * 
             * This is because when no filter is supplied, the 'General' filter is used.
             */
            Logger.Log(LogLevel.L2_Info, "This wont show, because we are still set to filter Car.Engine.");

            // -- Reset the filter to 'General'
            Logger.ResetFilter();

            // -- Now unspecified filter messages will print once again.
            Logger.Log(LogLevel.L1_Debug, "This will work again.");

            // -- Wait for input to close console
            Console.Read();
        }
    }

    /**
     * We create a class inheriting from Printer.
     * Implementing the Print method with our own functionality.
     */
    class ConsolePrinter : Printer
    {
        /**
         * This method can do anything, however we made the simplist of printers.
         * Often this can be used to print to a file instead, or a different logger entirely.
         * 
         * Unity would use:
         * Debug.Log(message);
         */
        public override void Print(string message)
        {
            Console.WriteLine("Console Printer: " + message);
        }
    }
}
