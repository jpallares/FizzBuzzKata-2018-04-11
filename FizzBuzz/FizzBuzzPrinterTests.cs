using System;
using Moq;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzPrinterTests
    {
        private Mock<ILinePrinter> mockPrinter;
        private FizzBuzzPrinter fizzBuzzPrinter;

        [SetUp]
        public void SetUp()
        {
            mockPrinter = new Mock<ILinePrinter>();
            fizzBuzzPrinter = new FizzBuzzPrinter(mockPrinter);
        }

        [Test]
        public void Prints_1()
        {
            mockPrinter.Verify(m => m.WriteLine("1"));
        }

        private interface ILinePrinter
        {
            void WriteLine(string output);
        }
    }
}
