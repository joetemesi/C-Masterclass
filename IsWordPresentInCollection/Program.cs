using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {
            //your code goes here
            int arrayLength = words.Length;
            bool isPresent = false;

            for (int i = 0; i < arrayLength; i++)
            {
                string myWord = words[i];

                isPresent = wordToBeChecked == myWord;

                if (isPresent)
                {
                    break;
                }

            }
            return isPresent;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple", "banana", "orange" };
            string wordToBeChecked = "banana";

            bool result = Exercise.IsWordPresentInCollection(words, wordToBeChecked);
            Console.WriteLine($"Is the word {wordToBeChecked} present in the collection? " + result);
            Console.ReadKey();
        }
    }
}

