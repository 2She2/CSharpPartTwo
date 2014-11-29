// 08. Write a program that extracts from a given text all sentences containing given word.
//     Example: The word is "in". The text is:
//     We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight.
//     So we are drinking all the day. We will move out of it in 5 days.

namespace _08.SentencesContainingGivenWord
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    class SentencesContainingGivenWord
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. dvsdgdgdgdf";
            string word = "in";
            string pattern = @"\s*([^\.]*\b" + word + @"\b.*?\.)";

            MatchCollection matches = Regex.Matches(text, pattern);

            // Loop to print all matches in "MatchCollection matches"
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
