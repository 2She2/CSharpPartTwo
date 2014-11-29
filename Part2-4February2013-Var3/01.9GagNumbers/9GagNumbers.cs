using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._9GagNumbers
{
    class Program
    {
        static void Main()

        {
            // 100 Points

            string input = Console.ReadLine();
            int startIndex = 0;
            int length = 1;
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                string search = input.Substring(startIndex, length);
                int number = FindNumber(search);

                if (number >= 0)
                {
                    startIndex += length;
                    length = 0;
                    numbers.Add(number);
                }

                length++;
            }

            numbers.Reverse();

            BigInteger totalSum = 0;
            BigInteger power = 1;

            for (int i = 0; i < numbers.Count; i++)
            {
                power = 1;
                for (int j = 0; j < i; j++)
                {
                    power *= 9;
                }

                totalSum += numbers[i] * power;
            }

            Console.WriteLine(totalSum);
        }

        static int FindNumber(string str)
        {
            switch (str)
            {
                case "-!": return 0;
                case "**": return 1;
                case "!!!": return 2;
                case "&&": return 3;
                case "&-": return 4;
                case "!-": return 5;
                case "*!!!": return 6;
                case "&*!": return 7;
                case "!!**!-": return 8;
                default: return -1;
            }
        }
    }
}
