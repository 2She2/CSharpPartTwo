using System;

namespace _01.Zerg
{
    class Zerg
    {
        static void Main()
        {
            // 100 Points

            string input = Console.ReadLine();
            string[] symbols = new string[input.Length / 4];
            int counter = 0;

            for (int i = 0; i < input.Length; i += 4)
            {
                symbols[counter] = input.Substring(i, 4);
                counter++;
            }

            Array.Reverse(symbols);

            long totalSum = 0;
            long currentNumber = 0;

            for (int i = 0; i < symbols.Length; i++)
            {
                currentNumber = FIndNumber(symbols[i]) * CalcPower(i);
                totalSum += currentNumber;
            }

            Console.WriteLine(totalSum);
        }

        static long CalcPower(int pow)
        {
            long power = 1;

            for (int i = 0; i < pow; i++)
            {
                power *= 15;
            }

            return power;
        }

        static int FIndNumber(string zerg)
        {
            switch (zerg)
            {
                case "Rawr": return 0;
                case "Rrrr": return 1;
                case "Hsst": return 2;
                case "Ssst": return 3;
                case "Grrr": return 4;
                case "Rarr": return 5;
                case "Mrrr": return 6;
                case "Psst": return 7;
                case "Uaah": return 8;
                case "Uaha": return 9;
                case "Zzzz": return 10;
                case "Bauu": return 11;
                case "Djav": return 12;
                case "Myau": return 13;
                case "Gruh": return 14;
                default: throw new ArgumentOutOfRangeException();
            }
        }
    }
}
