using Moq;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzPrinterShould
    {
        private Mock<ILinePrinter> mockPrinter;
        private Mock<IFizzBuzz> mockFizzBuzz;
        private FizzBuzzPrinter fizzBuzzPrinter;

        [SetUp]
        public void SetUp()
        {
            mockPrinter = new Mock<ILinePrinter>();
            mockFizzBuzz = new Mock<IFizzBuzz>();
            fizzBuzzPrinter = new FizzBuzzPrinter(mockPrinter.Object, mockFizzBuzz.Object);
        }

        [Test]
        public void Print_1()
        {
            fizzBuzzPrinter.Print();
            mockPrinter.Verify(m => m.WriteLine("1"));
        }

        [Test]
        public void Call_FizzBuzz_100_times()
        {
            fizzBuzzPrinter.Print();
            mockFizzBuzz.Verify(m => m.Execute(It.IsAny<int>()), Times.Exactly(100));
        }

        [Test]
        public void Call_WriteLine_100_times()
        {
            fizzBuzzPrinter.Print();
            mockPrinter.Verify(m => m.WriteLine(It.IsAny<string>()), Times.Exactly(100));
        }
    }
}
