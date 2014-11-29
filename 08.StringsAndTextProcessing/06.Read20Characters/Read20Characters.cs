// 06. Write a program that reads from the console a string of maximum 20 characters.
//     If the length of the string is less than 20, the rest of the characters should be filled with '*'.
//     Print the result string into the console.

namespace _06.Read20Characters
{
    using System;
    using System.Text;

    class Read20Characters
    {
        const int INPUT_STRING_LENGTH = 20;

        static void Main()
        {
            string inputText = Console.ReadLine();
            StringBuilder sb = new StringBuilder(inputText);

            // If string's chars are over, append '*'
            for (int i = 0; i < INPUT_STRING_LENGTH; i++)
            {
                if (i < inputText.Length)
                {
                    sb.Append(inputText[i]);
                }
                else
                {
                    sb.Append('*');
                }
            }

            Console.WriteLine(sb.ToString());

            ////Second way
            //if (inputText.Length < 20)
            //{
            //    Console.WriteLine(inputText.PadRight(20, '*'));
            //}
        }
    }
}
