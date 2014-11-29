// 20. Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

namespace _20.ExtractPalindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    class ExtractPalindromes
    {
        static void Main()
        {
            string text = "Some text ABBA, some more bob text lamal, and finally exe.";
            // Not sure, but palindromes have to be at least 2 chars. That is the "2" in {2,}
            string pattern = @"\b(\w{2,})\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            // Check each word in the sentence
            foreach (Match match in matches)
            {
                // Track if word is palindrome
                bool isPalindrome = true;

                for (int i = 0; i < match.Value.Length / 2; i++)
                {
                    // Check char by char if they are equal. First char begin from the strat, other one beging from the end.
                    if (match.Value[i] != match.Value[match.Value.Length - i - 1])
                    {
                        isPalindrome = false;
                    }
                }

                if (isPalindrome)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
