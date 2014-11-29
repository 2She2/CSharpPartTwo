// 02. Write a program to check if in a given expression the brackets are put correctly.
//     Example of correct expression: ((a+b)/5-d).
//     Example of incorrect expression: )(a+b)).

namespace _03.CheckExpressionBrackets
{
    using System;
    using System.Text.RegularExpressions;

    class CheckExpressionBrackets
    {
        static void Main()
        {
            string givenText;
            int bracketsCounter = 0;

            givenText = ReadInputString(); // Read text from the console, using method "ReadInputString()"

            Console.WriteLine(new string ('=', 40));

            // Check if first opening bracket is after closing bracket
            if (givenText.IndexOf(')') < givenText.IndexOf('('))
            {
                Console.WriteLine("First bracket can't be \")\"!");
                return;
            }

            // Check if last opening bracket is after last closing bracket
            if (givenText.LastIndexOf(')') < givenText.LastIndexOf('('))
            {
                Console.WriteLine("Last bracket can't be \"(\"!");
                return;
            }

            // Count the opening and closing brackets
            for (int i = 0; i < givenText.Length; i++)
            {
                if (givenText[i] == '(')
                {
                    bracketsCounter++;
                }
                else if (givenText[i] == ')')
                {
                    bracketsCounter--;
                }
            }

            if (bracketsCounter > 0)
            {
                Console.WriteLine("Opening brackets can't be more than closing brackets!");
            }
            else if (bracketsCounter < 0)
            {
                Console.WriteLine("Closing brackets can't be lass than opening brackets!");
            }
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
