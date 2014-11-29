// 05. You are given a text. Write a program that changes the text in all regions surrounded by the tags
//     <upcase> and </upcase> to uppercase. The tags cannot be nested. 
//     Example:
//     We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

namespace _05.ChangeTextToUppercase
{
    using System;
    using System.Text.RegularExpressions;

    class ChangeTextToUppercase
    {
        static void Main()
        {
            string givenText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            //string givenText = ReadInputString();
            string pattern = @"<upcase>(.*?)</upcase>";

            // Replace the strings, using Regular Expressions
            string editedText = Regex.Replace(givenText, pattern, m => m.Groups[1].Value.ToUpper());

            Console.WriteLine(new string('=', Console.WindowWidth - 1));
            Console.WriteLine("Text to uppercase: ");
            Console.WriteLine(editedText);
        }

        /// <summary>
        /// Read text from the console
        /// </summary>
        /// <returns>Text read from the console</returns>
        static private string ReadInputString()
        {
            string inputText;

            Console.Write("Enter expression: ");
            inputText = Console.ReadLine();

            return inputText;
        }
    }
}
