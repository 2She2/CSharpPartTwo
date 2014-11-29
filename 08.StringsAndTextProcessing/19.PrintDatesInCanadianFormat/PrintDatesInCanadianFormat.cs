// 19. Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//     Display them in the standard date format for Canada.

namespace _19.PrintDatesInCanadianFormat
{
    using System;
    using System.Globalization;
    using System.Text.RegularExpressions;
    using System.Threading;

    class PrintDatesInCanadianFormat
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

            string text = "17.05.2013 is Pesho's birth day 23.11.2013 and some more dates 10.03.2014.";
            string pattern = @"\b(\d{2}\.\d{2}\.\d{4})\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            // Print each match(date) in the standard date format for Canada
            foreach (Match match in matches)
            {
                DateTime date = DateTime.ParseExact(match.Value, "dd.MM.yyyy", new CultureInfo("en-CA"));
                Console.WriteLine(date.ToString(new CultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}
