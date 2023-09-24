using CSharpCalculator;
using NUnit.Framework;

namespace CalculatorTestsNUnit
{

    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TestCase(0, 1)]
        [TestCase(1.5, 0.0707)]
        [TestCase(3.2, -0.9978)]
        public void CheckCosGivenAngleReturnsExpectedResult(double angle, double expectedResult)
        {
            double result = calculator.Cos(angle);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(5, 5)]
        [TestCase(2.5, 2.5)]
        [TestCase(-8, 8)]
        public void CheckAbsGivenNumberReturnsExpectedResult(double number, double expectedResult)
        {
            double result = calculator.Abs(number);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(2, 3, 8)]
        [TestCase(1, 0, 1)]
        [TestCase(0, -2, 1)]
        public void CheckPowGivenBaseAndExponentReturnsExpectedResult(double x, double y, double expectedResult)
        {
            double result = calculator.Pow(x, y);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(5, 3, 2)]
        [TestCase(10.5, 3.5, 7)]
        [TestCase(0, 0, 0)]
        public void CheckSubGivenTwoNumbersReturnsExpectedResult(double a, double b, double expectedResult)
        {
            double result = calculator.Sub(a, b);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(5, 3, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(-2.5, -1.5, -4)]
        public void CheckAddGivenTwoNumbersReturnsExpectedResult(double a, double b, double expectedResult)
        {
            double result = calculator.Add(a, b);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(6, 2, 3)]
        [TestCase(15, 3, 5)]
        [TestCase(-5, 2, -2.5)]
        public void CheckDivideGivenDividendAndDivisorReturnsExpectedResult(double dividend, double divisor, double expectedResult)
        {
            double result = calculator.Divide(dividend, divisor);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(5, 3, 15)]
        [TestCase(0, 0, 0)]
        [TestCase(-2, -3, 6)]
        public void CheckMultiplyGivenTwoNumbersReturnsExpectedResult(double a, double b, double expectedResult)
        {
            double result = calculator.Multiply(a, b);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(0, 0)]
        [TestCase(1, 0.841)]
        [TestCase(0.5, 0.479)]
        public void CheckSinGivenAngleReturnsExpectedResult(double angle, double expectedResult)
        {
            double result = calculator.Sin(angle);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(4, 2)]
        [TestCase(9, 3)]
        [TestCase(16, 4)]
        public void CheckSqrtGivenNumberReturnsExpectedResult(double number, double expectedResult)
        {
            double result = calculator.Sqrt(number);
            Assert.AreEqual(expectedResult, result, 0.001);
        }

        [TestCase(-5, true)]
        [TestCase(0, false)]
        [TestCase(5, false)]
        public void CheckIsNegativeGivenNumberReturnsExpectedResult(double number, bool expectedResult)
        {
            bool result = calculator.isNegative(number);
            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(-5, false)]
        [TestCase(0, false)]
        [TestCase(5, true)]
        public void CheckIsPositiveGivenNumberReturnsExpectedResult(double number, bool expectedResult)
        {
            bool result = calculator.isPositive(number);
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void CheckGetTypeReturnsCalculatorType()
        {
            var result = calculator.GetType();
            Assert.AreEqual(typeof(Calculator), result);
        }
    }
}