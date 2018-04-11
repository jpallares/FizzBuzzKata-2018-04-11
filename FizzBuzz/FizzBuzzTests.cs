using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz = new FizzBuzz();

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        public void Outputs_input_if_not_divisible_by_3_nor_5(int input)
        {
            Assert.AreEqual(input.ToString(), fizzBuzz.Execute(input));
        }

        [TestCase(3)]
        [TestCase(6)]
        [TestCase(9)]
        public void Outputs_Fizz_for_input_divisible_by_3(int input)
        {
            Assert.AreEqual("Fizz", fizzBuzz.Execute(input));
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(20)]
        public void Outputs_Buzz_for_input_divisible_by_5(int input)
        {
            Assert.AreEqual("Buzz", fizzBuzz.Execute(input));
        }

        [Test]
        public void Outputs_FizzBuzz_for_input_15()
        {
            Assert.AreEqual("FizzBuzz", fizzBuzz.Execute(15));
        }

        [Test]
        public void Outputs_FizzBuzz_for_input_30()
        {
            Assert.AreEqual("FizzBuzz", fizzBuzz.Execute(30));
        }

        [Test]
        public void Outputs_FizzBuzz_for_input_45()
        {
            Assert.AreEqual("FizzBuzz", fizzBuzz.Execute(45));
        }
    }
}
