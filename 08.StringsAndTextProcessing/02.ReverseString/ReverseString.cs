// 02. Write a program that reads a string, reverses it and prints the result at the console.
//     Example: "sample"  "elpmas".

namespace _02.ReverseString
{
    using System;

    class ReverseString
    {
        static void Main()
        {
            string givenText;
            string reversedText;
            char[] charArray;

            givenText = ReadInputString(); // Read text from the console, using method "ReadInputString()"
            charArray = givenText.ToCharArray(); // Convert the text into a char array
            
            Array.Reverse(charArray); // Reverse the char array

            //// First way to print
            //Console.Write("Reversed text: ");
            //Console.WriteLine(charArray);

            reversedText = new string(charArray);

            // Second way to print
            Console.WriteLine("Reversed text: {0}", reversedText);
        }

        /// <summary>
        /// Read text from the console
        /// </summary>
        /// <returns>Text read from the console</returns>
        static private string ReadInputString()
        {
            string inputText;

            Console.Write("Enter text to reverse: ");
            inputText = Console.ReadLine();

            return inputText;
        }
    }
}
