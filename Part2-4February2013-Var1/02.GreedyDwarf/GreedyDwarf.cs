using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.GreedyDwarf
{
    class GreedyDwarf
    {
        static void Main()
        {
            // 100 Points

            string vall = Console.ReadLine();
            char[] separator = { ',', ' ' };
            bool[] isVisited;
            long maxCoins = long.MinValue;

            int M = int.Parse(Console.ReadLine());
            string[] patternsStrings = new string[M];
            int[][] patterns = new int[M][];

            // Parse valley numbers
            string[] valleyChars = vall.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int[] valley = new int[valleyChars.Length];

            for (int i = 0; i < valley.Length; i++)
            {
                valley[i] = int.Parse(valleyChars[i]);
            }

            // Parse patterns numbers
            for (int i = 0; i < M; i++)
            {
                patternsStrings[i] = Console.ReadLine();
                string[] patternsChars = patternsStrings[i].Split(separator, StringSplitOptions.RemoveEmptyEntries);
                patterns[i] = new int[patternsChars.Length];

                for (int j = 0; j < patternsChars.Length; j++)
                {
                    patterns[i][j] = int.Parse(patternsChars[j]);
                }
            }

            int index = 0;
            long coins = 0;

            // Calculate max coins
            for (int patternIndex = 0; patternIndex < M; patternIndex++)
            {
                isVisited = new bool[vall.Length];
                index = 0;
                coins = 0;

                for (int i = 0; i < patterns[patternIndex].Length; i++)
                {
                    if (!isVisited[index])
                    {
                        isVisited[index] = true;

                        coins += valley[index];
                        index += patterns[patternIndex][i];
                    }
                    else
                    {
                        break;
                    }

                    if (index >= valley.Length || index < 0)
                    {
                        break;
                    }

                    if (i == patterns[patternIndex].Length - 1)
                    {
                        i = -1;
                    }
                }

                if (coins > maxCoins)
                {
                    maxCoins = coins;
                }
            }
            
            Console.WriteLine(maxCoins);
        }
    }
}
