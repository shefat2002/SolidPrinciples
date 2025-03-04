namespace ISP
{
    // ISP - Violates
    //<------------------------------------------------------------------>
    public class BasicPrinter: IMultiFunctionPrinter
    {
        public void fax()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            Console.WriteLine("Printing Document.....");
        }

        public void scan()
        {
            throw new NotImplementedException();
        }
    }
    //<------------------------------------------------------------------>
}
