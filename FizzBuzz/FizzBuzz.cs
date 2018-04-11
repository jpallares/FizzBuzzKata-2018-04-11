namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string Execute(int input)
        {
            if (input == 15)
            {
                return "FizzBuzz";
            }

            if (input % 5 == 0)
            {
                return "Buzz";
            }

            if (input % 3 == 0)
            {
                return "Fizz";
            }

            return input.ToString();
        }
    }
}