using System;

namespace UnitTestingExercise.Tests
{
   public class UnitTestingMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers

        public int Add(int one, int two, int three)
        {
            return one + two + three;
        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtract(int minuend, int subtrhend)
        {
            return minuend - subtrhend;
        }

        // Create a Multiply method that passes 2 integers

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // Create a Divide method that passes 2 integers

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        // Create 2 methods that will utilize the [Fact] tests you wrote

        public bool IsCharSymbol(char testChar)
        {
            return char.IsSymbol(testChar);
        }

        public bool IsCharNotSymbol(char testChar)
        {
            return char.IsLetterOrDigit(testChar);
        }
    }
}