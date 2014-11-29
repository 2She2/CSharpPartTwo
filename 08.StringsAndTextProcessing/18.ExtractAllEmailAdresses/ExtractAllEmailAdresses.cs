// 18. Write a program for extracting all email addresses from given text.
//     All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

namespace _18.ExtractAllEmailAdresses
{
    using System;
    using System.Text.RegularExpressions;

    class ExtractAllEmailAdresses
    {
        static void Main()
        {
            string text = "Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk. This is not email: test@test. This also: @telerik.com. Neither this: a@a.b.";
            string pattern = @"([\w\.]+?@[\w\.]+?\.[a-zA-z]{2,4})(, |\. | |\z)";

            MatchCollection matches = Regex.Matches(text, pattern);

            // Print only the text in first pair of "()" - Groups[1]
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
