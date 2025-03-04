namespace ISP.PrinterISP
{
    public class BasicPrinter : IPrinter
    {
        public void print()
        {
            Console.WriteLine("Printing Document by basic printer...");
        }
    }
}
