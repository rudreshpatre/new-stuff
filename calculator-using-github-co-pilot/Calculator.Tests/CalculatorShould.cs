using Calculator.Domain;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorShould
    {
        private ICalculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator.Domain.Calculator();
        }

        [Test]
        public void AddTwoNumbers()
        {
            var result = _calculator.Add(1, 2);

            Assert.AreEqual(3, result);
        }

        [Test]
        public void SubtractTwoNumbers()
        {
            var result = _calculator.Subtract(1, 2);

            Assert.AreEqual(-1, result);
        }

        [Test]
        public void MultiplyTwoNumbers()
        {
            var result = _calculator.Multiply(1, 2);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void DivideTwoNumbers()
        {
            var result = _calculator.Divide(1, 2);

            Assert.AreEqual(0, result);
        }
    }
}


