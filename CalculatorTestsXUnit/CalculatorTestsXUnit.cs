using CSharpCalculator;
using Xunit;

namespace CalculatorTestsXUnit
{
    public class CalculatorTests
    {
        private Calculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(System.Math.PI, -1)]
        [InlineData(System.Math.PI / 2, 0)]
        public void CheckCosGivenAngleReturnsExpectedResult(double angle, double expectedResult)
        {
            double result = calculator.Cos(angle);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(5, 5)]
        [InlineData(-5, 5)]
        [InlineData(0, 0)]
        public void CheckAbsGivenNumberReturnsExpectedResult(double number, double expectedResult)
        {
            double result = calculator.Abs(number);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(2, 3, 8)]
        [InlineData(2, 0, 1)]
        [InlineData(2, -2, 0.25)]
        public void CheckPowGivenBaseAndExponentReturnsExpectedResult(double x, double y, double expectedResult)
        {
            double result = calculator.Pow(x, y);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(5, 3, 2)]
        [InlineData(-5, 3, -8)]
        [InlineData(0, 0, 0)]
        public void CheckSubGivenTwoNumbersReturnsExpectedResult(double a, double b, double expectedResult)
        {
            double result = calculator.Sub(a, b);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(5, 3, 8)]
        [InlineData(-5, -3, -8)]
        [InlineData(0, 0, 0)]
        public void CheckAddGivenTwoNumbersReturnsExpectedResult(double a, double b, double expectedResult)
        {
            double result = calculator.Add(a, b);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(-6, 2, -3)]
        [InlineData(5, 2, 2.5)]
        public void CheckDivideGivenDividendAndDivisorReturnsExpectedResult(double dividend, double divisor, double expectedResult)
        {
            double result = calculator.Divide(dividend, divisor);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(5, 3, 15)]
        [InlineData(-5, -3, 15)]
        [InlineData(0, 5, 0)]
        public void CheckMultiplyGivenTwoNumbersReturnsExpectedResult(double a, double b, double expectedResult)
        {
            double result = calculator.Multiply(a, b);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(System.Math.PI, 0)]
        [InlineData(System.Math.PI / 2, 1)]
        public void CheckSinGivenAngleReturnsExpectedResult(double angle, double expectedResult)
        {
            double result = calculator.Sin(angle);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(4, 2)]
        [InlineData(0, 0)]
        [InlineData(9, 3)]
        public void CheckSqrtGivenNumberReturnsExpectedResult(double number, double expectedResult)
        {
            double result = calculator.Sqrt(number);
            Assert.Equal(expectedResult, result, 3);
        }

        [Theory]
        [InlineData(-5, true)]
        [InlineData(0, false)]
        [InlineData(5, false)]
        public void CheckIsNegativeGivenNumberReturnsExpectedResult(double number, bool expectedResult)
        {
            bool result = calculator.isNegative(number);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(-5, false)]
        [InlineData(0, false)]
        [InlineData(5, true)]
        public void CheckIsPositiveGivenNumberReturnsExpectedResult(double number, bool expectedResult)
        {
            bool result = calculator.isPositive(number);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void CheckGetTypeReturnsCalculatorType()
        {
            var result = calculator.GetType();
            Assert.Equal(typeof(Calculator), result);
        }
    }

}