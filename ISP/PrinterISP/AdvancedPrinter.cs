namespace ISP.PrinterISP
{
    public class AdvancedPrinter : IPrinter, IScanner,IFax
    {
        public void fax()
        {
            Console.WriteLine("Sending Fax...");
        }

        public void print()
        {
            Console.WriteLine("Printing Document by advanced printer...");
        }

        public void scan()
        {
            Console.WriteLine("Scanning Document...");
        }
    }
}
