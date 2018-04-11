namespace FizzBuzz
{
    public class FizzBuzzPrinter
    {
        private readonly ILinePrinter _printer;
        private readonly IFizzBuzz _fizzBuzz;

        public FizzBuzzPrinter(ILinePrinter printer, IFizzBuzz fizzBuzz)
        {
            _printer = printer;
            _fizzBuzz = fizzBuzz;
        }
        
        public void Print()
        {
            for (int i = 1; i <= 100; i++)
            {
                _printer.WriteLine(_fizzBuzz.Execute(i));
            }
        }
    }
}