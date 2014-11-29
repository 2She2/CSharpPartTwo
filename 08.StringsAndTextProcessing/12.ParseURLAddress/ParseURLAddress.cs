// 12. Write a program that parses an URL address given in the format:
//     [protocol]://[server]/[resource]
//     and extracts from it the [protocol], [server] and [resource] elements.
//     For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
//	   [protocol] = "http"
//	   [server] = "www.devbg.org"
//	   [resource] = "/forum/index.php"

namespace _12.ParseURLAddress
{
    using System;
    using System.Text.RegularExpressions;

    class ParseURLAddress
    {
        static void Main()
        {
            string URL = "http://www.devbg.org/forum/index.php";
            string pattern = @"(.*)://(.*?)(/.*)";
            MatchCollection matches =  Regex.Matches(URL, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine("[protocol] = {0}", match.Groups[1]);
                Console.WriteLine("[server] = {0}", match.Groups[2]);
                Console.WriteLine("[resource] = {0}", match.Groups[3]);
            }
        }
    }
}
