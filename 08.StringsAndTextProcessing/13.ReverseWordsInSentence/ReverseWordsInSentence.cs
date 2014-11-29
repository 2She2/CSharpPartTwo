// 13. Write a program that reverses the words in given sentence.
//     Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

namespace _13.ReverseWordsInSentence
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class ReverseWordsInSentence
    {
        static void Main()
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string[] words = text.Split(new string[] { " ", ",", ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries);
            string[] separators = Regex.Split(text, @"[a-zA-Z0-9#+]");

            StringBuilder reversedText = new StringBuilder(text.Length);

            // Reverse the array, so we have the words in reverse order
            Array.Reverse(words);

            // Extract the punctuation and spaces
            List<string> punctuation = new List<string>();
            for (int i = 0; i < separators.Length; i++)
            {
                if (separators[i] != string.Empty)
                {
                    punctuation.Add(separators[i]);
                }
            }

            // Append puctuation and words in reverse order
            for (int i = 0; i < punctuation.Count; i++)
            {
                if (i < words.Length)
                {
                    reversedText.Append(words[i]);
                }

                reversedText.Append(punctuation[i]);
            }

            Console.WriteLine("Reverse sentence:");
            Console.WriteLine(reversedText.ToString());
        }
    }
}
