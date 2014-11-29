// 25. Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
//     Example:
/*
<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skillful .NET software engineers.</p></body>
</html>
*/

namespace _25.ExtractTitleAndBodyFromHTML
{
    using System;
    using System.IO;
    using System.Text.RegularExpressions;

    class ExtractTitleAndBodyFromHTML
    {
        static void Main()
        {
            string htmlText;
            
            string textPattern = @">([^<>]+)</";
            Match title;
            MatchCollection textMatches;

            //// First way to read file
            //htmlText = File.ReadAllText(@"..\..\html.txt");

            // Second way to read file
            StreamReader reader = new StreamReader(@"..\..\html.txt");

            using (reader)
            {
                htmlText = reader.ReadToEnd();
            }

            //// Extract only title
            //string titlePattern = @"<title>(<\w*>)*(.*?)(</\w*>)*</title>";
            //title = Regex.Match(htmlText, titlePattern);
            //Console.WriteLine(title.Groups[2]);

            // Find maches
            textMatches = Regex.Matches(htmlText, textPattern);

            // Print each match in group 1 "([^<>]+)"
            foreach (Match match in textMatches)
            {
                Console.WriteLine(match.Groups[1]);
            }
        }
    }
}
