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
            _printer.WriteLine("1");

            for (int i = 0; i < 100; i++)
            {
                _fizzBuzz.Execute(i);
            }
        }
    }
}