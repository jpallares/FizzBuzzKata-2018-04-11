namespace FizzBuzz
{
    public class FizzBuzzPrinter
    {
        private readonly ILinePrinter _printer;

        public FizzBuzzPrinter(ILinePrinter printer)
        {
            _printer = printer;
        }
        
        public void Print()
        {
            _printer.WriteLine("1");
        }
    }
}