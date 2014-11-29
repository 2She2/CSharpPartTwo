// 22. Write a program that reads a string from the console and lists all different words in the string
//     along with information how many times each word is found.

namespace _22.PrintAndCountDifferentWords
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class PrintAndCountDifferentWords
    {
        static void Main()
        {
            // Directly set the string to lower case, so we can find all words, no matter upper or lower case
            string text = "Write a program write reads a string. Program the console words, console write the words console the string write console the words many times words many the found.".ToLower();
            
            // Split the string by punctuation and remove the empty strings
            string[] matches = text.Split(new char[] { '.', ',', ' ', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            // Group the words - "GroupBy(m => m)"
            var words = matches.GroupBy(m => m);

            // Print each word and how many times it is found
            foreach (var word in words)
            {
                Console.WriteLine("{0,10}: {1}", word.Key, word.Count());
            }
        }
    }
}
