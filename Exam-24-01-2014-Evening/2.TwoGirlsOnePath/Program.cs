using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2.TwoGirlsOnePath
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] numbersString = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            long[] numbers = new long[numbersString.Length];
            

            for (long i = 0; i < numbers.Length; i++)
            {
                numbers[i] = long.Parse(numbersString[i]);
            }

            BigInteger mollyFlowers = 0;
            BigInteger dollyFlowers = 0;

            long mollyIndex = 0;
            long dollyIndex = numbers.Length - 1;

            bool isMolly = false;
            bool isDolly = false;

            long prevMollyIndex = 0;
            long prevDollyIndex = numbers.Length - 1;


            while (true)
            {
                if (numbers[mollyIndex] == -1 && numbers[dollyIndex] == -1)
                {
                    isMolly = true;
                    isDolly = true;
                    break;
                }
                if (numbers[mollyIndex] == -1)
                {
                    isMolly = true;
                    dollyFlowers += numbers[dollyIndex];
                    break;
                }
                if (numbers[dollyIndex] == -1)
                {
                    isDolly = true;
                    mollyFlowers += numbers[mollyIndex];
                    break;
                }

                if (mollyIndex == dollyIndex)
                {
                    // can be optimized
                    if (numbers[mollyIndex] >= 0 && numbers[dollyIndex] >= 0)
                    {
                        long curNumber = numbers[dollyIndex] / 2;
                        mollyFlowers += numbers[curNumber] / 2;
                        dollyFlowers += numbers[curNumber] / 2;
                    }
                }
                else
                {
                    if (numbers[mollyIndex] >= 0)
                    {
                        mollyFlowers += numbers[mollyIndex];
                    }

                    if (numbers[dollyIndex] >= 0)
                    {
                        dollyFlowers += numbers[dollyIndex];
                    }

                }

                prevMollyIndex = mollyIndex;
                prevDollyIndex = dollyIndex;

                BigInteger moll = mollyIndex + numbers[mollyIndex];
                BigInteger doll = numbers[dollyIndex] % numbers.Length;

                mollyIndex = (long)(moll % numbers.Length);
                dollyIndex = (dollyIndex - (long)doll);

                if (dollyIndex < 0)
                {
                    dollyIndex = numbers.Length + dollyIndex;
                }
                
                numbers[prevMollyIndex] = -1;
                numbers[prevDollyIndex] = -1;
            }

            if (isMolly && isDolly)
            {
                Console.WriteLine("Draw");
            }
            else if (isMolly)
            {
                Console.WriteLine("Dolly");
            }
            else if (isDolly)
            {
                Console.WriteLine("Molly");
            }
            Console.WriteLine("{0} {1}", mollyFlowers, dollyFlowers);
        }
    }
}
