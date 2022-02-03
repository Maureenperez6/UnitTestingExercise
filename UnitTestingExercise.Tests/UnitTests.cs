using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        [InlineData(10,10,10,30)]
        [InlineData(1,1,1,3)]
        [InlineData(-1,6,-3,2)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange
            var test = new UnitTestingMethods();

            //Act
            var actual = test.Add(num1, num2, num3);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(5,10,-5)]    
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test = new UnitTestingMethods();

            //Act
            var actual = test.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2,2,4)]
        [InlineData(5,4,20)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestingMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20,5,4)]
        [InlineData(4,2,2)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestingMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange
            var test = new UnitTestMethods();
            string symbols = "$~^+<>";
            foreach (char character in symbols)
            {

                //Act
                var isSymbolActual = test.IsCharSymbol(character);

                //Assert
                Assert.True(isSymbolActual);

            }

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange
            var test = new UnitTestMethods();
            string lettersAndNums = "0123456789abcdefghijklmnopqrstuvwxyz";

            foreach (var character in lettersAndNums)
            {

                //Act
                bool isSymbolActual = test.IsCharNotSymbol(character);

                //Assert
                Assert.True(isSymbolActual);

            }
        }
    }
}
