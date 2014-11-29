namespace _02.MagicWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class MagicWords
    {
        static void Main()
        {
            // 100 Points

            int numbersCount = int.Parse(Console.ReadLine());
            List<string> words = new List<string>(1000);

            for (int i = 0; i < numbersCount; i++)
            {
                words.Add(Console.ReadLine());
            }

            int longestWord = 0;
            StringBuilder sb = new StringBuilder(10000);

            for (int i = 0; i < words.Count; i++)
            {
                int inputPlace = words[i].Length % (words.Count + 1);
                int removeIndex = i;

                if (inputPlace < removeIndex)
                {
                    removeIndex += 1;
                }

                words.Insert(inputPlace, words[i]);
                words.RemoveAt(removeIndex);
            }

            for (int i = 0; i < words.Count; i++)
            {
                if (words[i].Length > longestWord)
                {
                    longestWord = words[i].Length;
                }
            }

            for (int i = 0; i < longestWord; i++)
            {
                for (int j = 0; j < words.Count; j++)
                {
                    if (words[j].Length > i)
                    {
                        sb.Append(words[j][i]);
                    }
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
