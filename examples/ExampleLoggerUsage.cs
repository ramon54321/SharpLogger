using System;
namespace SharpLogger.Examples
{
    public class ExampleLoggerUsage
    {
        public ExampleLoggerUsage()
        {
            // -- Create a new object of this type and view the output.

            // -- Set up the logger
            // TODO: Write example usage
            //Logger.SetPrinter(new )


        }
    }

    class ConsolePrinter : Printer
    {
        public override void Print(string message)
        {
            throw new NotImplementedException();
        }
    }
}
