// 23. Write a program that reads a string from the console and replaces all series of consecutive identical letters
//     with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

namespace _23.ReplaceConsecutiveLetters
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ReplaceConsecutiveLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa, dddfffgggggggeeeee wwwttttfffff.";

            // Using "Backreference" for regular expressions
            string pattern = @"(\w)\1+";

            // Replace consecutive identical letters with a single one
            text = Regex.Replace(text, pattern, "$1");
            
            Console.WriteLine(text);
        }
    }
}
