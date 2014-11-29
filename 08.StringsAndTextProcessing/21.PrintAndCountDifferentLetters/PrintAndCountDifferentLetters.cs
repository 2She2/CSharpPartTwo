// 21. Write a program that reads a string from the console
//     and prints all different letters in the string
//     along with information how many times each letter is found. 

namespace _21.PrintAndCountDifferentLetters
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class PrintAndCountDifferentLetters
    {
        static void Main()
        {
            // Directly set the string to lower case, so we can find all letters, no matter upper or lower case
            string text = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.".ToLower();
            
            // Remove all non letters(a-z) characters
            string pattern = "[^a-z]";
            text = Regex.Replace(text, pattern, m => m.Result(new string(' ', 0)));

            // Group the char - "GroupBy(m => m)"
            var chars = text.ToCharArray().GroupBy(m => m);

            // Print each char and how many times it is found
            foreach (var element in chars)
            {
                Console.WriteLine("{0}: {1}", element.Key, element.Count());
            }
        }
    }
}
