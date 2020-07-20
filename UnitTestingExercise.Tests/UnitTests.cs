using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(4, 5, 6, 15)]
        [InlineData(300, 300, 200, 800)]
        [InlineData(-1, 5, -4, 0)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();
            //Act
            var actual = calculator.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 4, 1)]
        [InlineData(50, 20, 30)]
        [InlineData(-1, 14, -15)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();
            //Act
            var actual = calculator.Subtract(minuend, subtrahend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 9, 81)]
        [InlineData(2, 3, 6)]
        [InlineData(2, -1, -2)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();
            //Act
            var actual = calculator.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(12, 5, 2)]
        [InlineData(100, 0, -1)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var calculator = new UnitTestMethods();
            //Act
            var actual = calculator.Divide(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("string", "tringsay")]
        public void PigLatin(string str, string expected)
        {
            //Arrange
            var tester = new UnitTestMethods();
            //Act
            var actual = tester.PigLatin(str);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
