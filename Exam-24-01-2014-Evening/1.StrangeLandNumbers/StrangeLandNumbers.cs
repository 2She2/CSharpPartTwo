using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.StrangeLandNumbers
{
    class StrangeLandNumbers
    {
        static void Main()
        {

            string input = Console.ReadLine();
            List<int> numbers = new List<int>();

            int startIndex = 0;
            int length = 1;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = FIndNubmer(input.Substring(startIndex, length));
                if (currentNumber >= 0)
                {
                    numbers.Add(currentNumber);
                    startIndex = i + 1;
                    length = 0;
                }

                length++;
            }

            long curerntSum = 0;
            long totalSum = 0;
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                curerntSum = CalcPower(i) * numbers[i];
                totalSum += curerntSum;
            }

            Console.WriteLine(totalSum);
        }

        static long CalcPower(int pow)
        {
            long power = 1;

            for (int i = 0; i < pow; i++)
            {
                power *= 7;
            }

            return power;
        }

        static int FIndNubmer(string str)
        {

            switch (str)
            {
                case "f": return 0;
                case "bIN": return 1;
                case "oBJEC": return 2;
                case "mNTRAVL": return 3;
                case "lPVKNQ": return 4;
                case "pNWE": return 5;
                case "hT": return 6;
                default: return -1;
            }
        }
    }
}
