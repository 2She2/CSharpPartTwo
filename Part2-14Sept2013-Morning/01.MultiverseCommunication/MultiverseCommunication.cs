namespace _01.MultiverseCommunication
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class MultiverseCommunication
    {
        static void Main()
        {
            // 100 Points

            string str = Console.ReadLine();
            int powerCounter = str.Length / 3 - 1;
            long totalSum = 0;

            for (int i = 0; i < str.Length; i += 3)
            {
                int currentNumber = 0;
                long power = 1;

                switch (str.Substring(i, 3))
                {
                    case "CHU": currentNumber = 0; break;
                    case "TEL": currentNumber = 1; break;
                    case "OFT": currentNumber = 2; break;
                    case "IVA": currentNumber = 3; break;
                    case "EMY": currentNumber = 4; break;
                    case "VNB": currentNumber = 5; break;
                    case "POQ": currentNumber = 6; break;
                    case "ERI": currentNumber = 7; break;
                    case "CAD": currentNumber = 8; break;
                    case "K-A": currentNumber = 9; break;
                    case "IIA": currentNumber = 10; break;
                    case "YLO": currentNumber = 11; break;
                    case "PLA": currentNumber = 12; break;
                    default: throw new ArgumentOutOfRangeException();
                }

                for (int j = 0; j < powerCounter; j++)
                {
                    power *= 13;
                }

                totalSum += currentNumber * power;
                powerCounter--;
            }

            Console.WriteLine(totalSum);
        }
    }
}
