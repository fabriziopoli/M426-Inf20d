using System;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAddThreeToTwoPIsFive()
        {
            // Arrange
            int a = 2;
            int b = 3;
            int expected = 5;
            Calculator calculator = new Calculator();

            // Act
            int actual = calculator.Add(a, b);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestSubtractFourFromSixIsTwo()
        {
            // Given
            int a = 6;
            int b = 4;
            int expected = 2;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Subtract(a, b);

            // Then
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestDivideTwoFromSixIsThree()
        {
            // Given
            int a = 6;
            int b = 2;
            int expected = 3;
            Calculator calculator = new Calculator();

            // When
            int actual = calculator.Divide(a, b);

            // Then
            Assert.Equal(expected, actual);
        }
    }
}
