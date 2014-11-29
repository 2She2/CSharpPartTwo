using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.ConsoleJustification
{
    class ConsoleJustification
    {
        static void Main()
        {
            // 100 Points

            int N = int.Parse(Console.ReadLine());
            int W = int.Parse(Console.ReadLine());
            string[] text = new string[N];
            List<string> words = new List<string>(100);

            for (int i = 0; i < N; i++)
            {
                text[i] = Console.ReadLine();
            }

            for (int i = 0; i < text.Length; i++)
            {
                string[] temp = text[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < temp.Length; j++)
                {
                    words.Add(temp[j]);
                }
            }

            StringBuilder line = new StringBuilder();
            int wordsPerLine = 0;

            for (int i = 0; i < words.Count; i++)
            {
                if (line.Length + words[i].Length <= W)
                {
                    line.Append(words[i]);
                    line.Append(' ');
                    wordsPerLine++;
                }
                else
                {
                    InsertSpaces(line, wordsPerLine, W);

                    Console.WriteLine(line.ToString());
                    line.Clear();
                    wordsPerLine = 0;
                    i--;
                }

                if (i == words.Count - 1)
                {
                    InsertSpaces(line, wordsPerLine, W);

                    Console.WriteLine(line.ToString());
                }
            }
        }

        static void InsertSpaces(StringBuilder row, int wordsCount, int width)
        {
            row.Remove(row.Length - 1, 1);

            int space = width - row.Length;

            if (wordsCount > 1)
            {
                while (space > 0)
                {
                    for (int j = 0; j < row.Length; j++)
                    {
                        if (row[j].ToString().Equals(" ") && !row[j-1].ToString().Equals(" "))
                        {
                            row.Insert(j, ' ');
                            j++;
                            space--;
                        }

                        if (space <= 0)
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
