// 04. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).

namespace _04.FindSubstringCount
{
    using System;
    using System.Text.RegularExpressions;

    class FindSubstringCount
    {
        static void Main()
        {
            string giventext = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".ToLower();
            string substring = "in";

            //// First way
            //string[] str = { substring };
            //string[] s = giventext.Split(str, 100, StringSplitOptions.None);
            //Console.WriteLine("The result is: {0}", s.Length - 1);

            // Second way;
            // Using "RegularExpressions"
            int matchesCount = Regex.Matches(giventext, substring, RegexOptions.IgnoreCase).Count;
            Console.WriteLine("The result is: {0}", matchesCount);
        }
    }
}
