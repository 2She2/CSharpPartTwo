using System;
using System.Text;

namespace _02.MovingLetters
{
    class MovingLetters
    {
        static void Main()
        {
            // 100 Points

            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder(100);

            int maxLength = 0;

            for (int i = 0; i < words.Length; i++)
            {
                char[] currentWord = words[i].ToCharArray();
                Array.Reverse(currentWord);
                words[i] = new string(currentWord);

                if (words[i].Length > maxLength)
                {
                    maxLength = words[i].Length;
                    
                }
            }

            for (int i = 0; i < maxLength; i++)
            {
                for (int j = 0; j < words.Length; j++)
                {
                    if (i < words[j].Length)
                    {
                        sb.Append(words[j][i]);
                    }
                }
            }

            for (int i = 0; i < sb.Length; i++)
            {
                char curChar = sb[i];
                int charMoves = char.ToLower(curChar) - 96;
                int currentPosition = CalcPosition(i, charMoves, sb.Length);
                sb.Remove(i, 1);
                sb.Insert(currentPosition, curChar);
            }

            Console.WriteLine(sb.ToString());
        }

        static int CalcPosition(int curIndex, int moves, int length)
        {
            for (int i = 0; i < moves; i++)
            {
                curIndex++;

                if (curIndex == length)
                {
                    curIndex = 0;
                }
            }

            return curIndex;
        }
    }
}
