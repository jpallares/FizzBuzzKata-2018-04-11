namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Execute(int input)
        {
            if (input == 3)
            {
                return "Fizz";
            }

            if (input == 5)
            {
                return "Buzz";
            }

            return input.ToString();
        }
    }
}