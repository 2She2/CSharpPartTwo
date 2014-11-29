using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DurankulakNumbers
{
    class DurankulakNumbers
    {
        static void Main()
        {
            // 100 Points

            string durNumber = Console.ReadLine();
            int powerCount = 0;
            long powerSum = 1;
            long currentNumber = 0;
            long sum = 0;


            for (int i = durNumber.Length - 1; i >= 0; i--)
            {
                currentNumber = 0;
                powerSum = 1;

                if (char.IsUpper(durNumber[i]))
                {
                    currentNumber += (durNumber[i] - 'A');

                    if ((i - 1) >= 0 && char.IsLower(durNumber[i - 1]))
                    {
                        currentNumber += ((durNumber[i - 1] - 'a' + 1) * 26);

                        i--;
                    }

                    for (int p = 0; p < powerCount; p++)
                    {
                        powerSum *= 168;
                    }

                    sum += currentNumber * powerSum;
                    powerCount++;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
