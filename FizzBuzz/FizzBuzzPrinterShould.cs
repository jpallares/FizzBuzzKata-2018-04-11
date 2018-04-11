using Moq;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzPrinterShould
    {
        private Mock<ILinePrinter> mockPrinter;
        private FizzBuzzPrinter fizzBuzzPrinter;

        [SetUp]
        public void SetUp()
        {
            mockPrinter = new Mock<ILinePrinter>();
            fizzBuzzPrinter = new FizzBuzzPrinter(mockPrinter.Object);
        }

        [Test]
        public void Print_1()
        {
            fizzBuzzPrinter.Print();
            mockPrinter.Verify(m => m.WriteLine("1"));
        }

        [Test]
        public void Use_call_FizzBuzz_100_times()
        {
            fizzBuzzPrinter.Print();
            mockPrinter.Verify(m => m.WriteLine(It.IsAny<string>()), Times.Exactly(100));
        }
    }
}
