// 14. A dictionary is stored as a sequence of text lines containing words and their explanations.
//     Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
//     .NET – platform for applications from Microsoft
//     CLR – managed execution environment for .NET
//     namespace – hierarchical organization of classes

namespace _14.TranslateWordInDictionary
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class TranslateWordInDictionary
    {
        static void Main()
        {
            string[] dictionary = 
            {
                ".NET – platform for applications from Microsoft", 
                "CLR – managed execution environment for .NET", 
                "namespace – hierarchical organization of classes"
            };

            string word = ".NET";
            string pattern = @"(.+) – (.+)";

            // For each line in the string array, set the string in two groups. First group - word, second - explanation
            // If group 1(word) matches the input word, print current dictionary element
            for (int i = 0; i < dictionary.Length; i++)
            {
                Match match = Regex.Match(dictionary[i], pattern);

                if (match.Groups[1].Value.Equals(word))
                {
                    Console.WriteLine(dictionary[i]);
                }
            }
        }
    }
}
