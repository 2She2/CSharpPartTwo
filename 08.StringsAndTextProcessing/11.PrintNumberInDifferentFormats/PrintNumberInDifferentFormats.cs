// 11. Write a program that reads a number and prints it as a decimal number, hexadecimal number,
//     percentage and in scientific notation. Format the output aligned right in 15 symbols.

namespace _11.PrintNumberInDifferentFormats
{
    using System;

    class PrintNumberInDifferentFormats
    {
        static void Main()
        {
            int givenNumber = ReadInteger();

            Console.WriteLine("{0,15:F} - decimal", givenNumber);
            Console.WriteLine("{0,15:X} - hexadecimal", givenNumber);
            Console.WriteLine("{0,15:P} - percentage", givenNumber);
            Console.WriteLine("{0,15:E} - scientific", givenNumber);
        }

        // Validate input number
        private static int ReadInteger()
        {
            int number;

            Console.Write("Enter integer number: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Enter correct number: ");
            }

            return number;
        }
    }
}
