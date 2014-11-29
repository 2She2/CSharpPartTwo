// 24. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

namespace _24.PrintWordsInAlphabeticalOrder
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class PrintWordsInAlphabeticalOrder
    {
        static void Main()
        {
            string text = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order";

            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Sort the words in alphabetical order
            Array.Sort(words);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
