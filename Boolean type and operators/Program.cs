
//To the isSumLargerOrEqualTo17 variable, assign true if the sum of a and b is larger or equal to 17 and false otherwise.
using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static bool BooleanTypesAndOperators()
        {
            int a = 5;
            int b = 12;

            bool isSumLargerOrEqualTo17 = (a + b) >= 17;

            return isSumLargerOrEqualTo17;
        }

        public static void Main(string[] args)
        {
            // Call the BooleanTypesAndOperators method and print the result
            Console.WriteLine(BooleanTypesAndOperators());
            Console.ReadKey();
        }
    }
}


