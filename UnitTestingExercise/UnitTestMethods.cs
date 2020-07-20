using System;
using System.ComponentModel;

namespace UnitTestingExercise
{
    public class UnitTestMethods
    {
        // Make sure your references are set properly
        // Righ-click on Dependencies in your .Tests project and set your reference



        // Create an Add method that passes 3 integers
        public int Add(int int1, int int2, int int3)
        {
            return int1 + int2 + int3;
        }

        // Create a Subtract method that passes 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend
        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        // Create a Multiply method that passes 2 integers
        public int Multiply(int int1, int int2)
        {
            return int1 * int2;
        }

        // Create a Divide method that passes 2 integers
        public int Divide(int int1, int int2)
        {
            try
            {
                return int1 / int2;
            }
            catch
            {
                Console.WriteLine("Cannot divide by 0");
                return -1;
            }
        }


        // Create 2 methods that will utilize the [Fact] tests you wrote
        public string PigLatin(string str)
        {
            char c = str[0];
            string toReturn = str.Substring(1);
            return $"{toReturn}{c}ay";
        }

        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }

    }
}
