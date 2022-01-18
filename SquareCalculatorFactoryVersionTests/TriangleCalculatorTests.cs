using NUnit.Framework;
using SquareCalculatorFactoryVersion.Calculator.SquareCalculators;

namespace SquareCalculatorFactoryVersionTests
{
    public class TriangleCalculatorTests
    {
        private TriangleSquareCalculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            calculator = new();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}