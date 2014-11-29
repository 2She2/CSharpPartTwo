// 09. We are given a string containing a list of forbidden words and a text containing some of these words.
//     Write a program that replaces the forbidden words with asterisks. Example:
//     Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

//     Words: "PHP, CLR, Microsoft"
//     The expected result:
//     ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

namespace _09.ReplaceForbiddenWords
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class ReplaceForbiddenWords
    {
        static void Main()
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] words = { "PHP", "CLR", "Microsoft" };
            string pattern = @"(\b" + words[0] + @"\b|\b" + words[1] + @"\b|\b" + words[2] + @"\b)";

            // Find if text contains some of the words and replace it with '*' as the length of the word
            string str = Regex.Replace(text, pattern, m => m.Result(new string('*', m.Length)));
            Console.WriteLine(str);
        }
    }
}
