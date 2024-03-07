using System;

namespace Coding.Exercise
{
    public class Program
    {
        public static string IsElseConditionalStatement()
        {
            int number = 10;
            string result;

            if (number < 0)
            {
                result = "Negative";
            }
            else if (number == 0)
            {
                result = "Zero";
            }
            else
            {
                result = "Positive";
            }

            return result;
        }

        public static void Main(string[] args)
        {
            // Call the IsElseConditionalStatement method and print the result
            Console.WriteLine(IsElseConditionalStatement());
            Console.ReadKey (); 
           
        }
    }
}
