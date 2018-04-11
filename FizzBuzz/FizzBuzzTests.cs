using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private FizzBuzz fizzBuzz = new FizzBuzz();

        [Test]
        public void Outputs_1_for_input_1()
        {
            Assert.AreEqual("1", fizzBuzz.Execute(1));
        }

        [Test]
        public void Outputs_2_for_input_2()
        {
            Assert.AreEqual("2", fizzBuzz.Execute(2));
        }

        [Test]
        public void Outputs_Fizz_for_input_3()
        {
            Assert.AreEqual("Fizz", fizzBuzz.Execute(3));
        }

        [Test]
        public void Outputs_Buzz_for_input_5()
        {
            Assert.AreEqual("Buzz", fizzBuzz.Execute(5));
        }

        [Test]
        public void Outputs_4_for_input_4()
        {
            Assert.AreEqual("4", fizzBuzz.Execute(4));
        }
    }
}
