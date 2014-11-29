using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Digits
{
    class Digits
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string digitsString;
            int[,] digits = new int[N, N];

            for (int row = 0; row < N; row++)
            {
                digitsString = Console.ReadLine();
                string[] currLine = digitsString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < N; col++)
                {
                    digits[row, col] = (currLine[col][0] - '0');
                }
            }

            long onesCount = 0;
            long twosCount = 0;
            long threesCount = 0;
            long foursCount = 0;
            long fivesCount = 0;
            long sixsCount = 0;
            long sevensCount = 0;
            long eightsCount = 0;
            long ninesCount = 0;

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    if (digits[row, col] == 1)
                    {
                        onesCount += OnePattern(row, col, digits);
                    }
                    else if (digits[row, col] == 2)
                    {
                        twosCount += TwoPattern(row, col, digits);
                    }
                    else if (digits[row, col] == 3)
                    {
                        threesCount += ThreePattern(row, col, digits);
                    }
                    else if (digits[row, col] == 4)
                    {
                        foursCount += FourPattern(row, col, digits);
                    }
                    else if (digits[row, col] == 5)
                    {
                        fivesCount += FivePattern(row, col, digits);
                    }
                    else if (digits[row, col] == 6)
                    {
                        sixsCount += SixPattern(row, col, digits); ;
                    }
                    else if (digits[row, col] == 7)
                    {
                        sevensCount += SevenPattern(row, col, digits);
                    }
                    else if (digits[row, col] == 8)
                    {
                        eightsCount += EightPattern(row, col, digits);
                    }
                    else if (digits[row, col] == 9)
                    {
                        ninesCount += NinePattern(row, col, digits);
                    }
                }
            }

            long totalSum = onesCount + twosCount + threesCount + foursCount + fivesCount + sixsCount + sevensCount + eightsCount + ninesCount;
            Console.WriteLine(totalSum);

        }

        static int OnePattern(int row, int col, int[,] digits)
        {
            if (row < 2 || col > digits.GetLength(0) - 3 || row + 2 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row - 1, col + 1] == 1 && 
					 digits[row - 2, col + 2] == 1 && 
					 digits[row - 1, col + 2] == 1 &&
                     digits[row, col + 2] == 1 && 
					 digits[row + 1, col + 2] == 1 && 
					 digits[row + 2, col + 2] == 1)
            {

                return 1;
            }
            else
            {
                return 0;
            }
        }

        static int TwoPattern(int row, int col, int[,] digits)
        {
            if (row < 1 || col > digits.GetLength(0) - 3 || row + 3 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row - 1, col + 1] == 2 && digits[row, col + 2] == 2 && digits[row + 1, col + 2] == 2 &&
                    digits[row + 2, col + 1] == 2 && digits[row + 3, col] == 2 && digits[row + 3, col + 1] == 2 &&
                    digits[row + 3, col + 2] == 2)
            {
                return 2;
            }
            else
            {
                return 0;
            }

        }

        static int ThreePattern(int row, int col, int[,] digits)
        {
            if (col > digits.GetLength(0) - 3 || row + 4 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row, col + 1] == 3 && digits[row, col + 2] == 3 && digits[row + 1, col + 2] == 3 &&
                digits[row + 2, col + 2] == 3 && digits[row + 3, col + 2] == 3 && digits[row + 4, col + 2] == 3 &&
                digits[row + 2, col + 1] == 3 && digits[row + 4, col] == 3 && digits[row + 4, col + 1] == 3)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }

        static int FourPattern(int row, int col, int[,] digits)
        {
            if (col > digits.GetLength(0) - 3 || row + 4 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row + 1, col] == 4 && digits[row + 2, col] == 4 && digits[row + 2, col + 1] == 4 &&
                digits[row, col + 2] == 4 && digits[row + 1, col + 2] == 4 && digits[row + 2, col + 2] == 4 &&
                digits[row + 3, col + 2] == 4 && digits[row + 4, col + 2] == 4)
            {
                return 4;
            }
            else
            {
                return 0;
            }
        }

        static int FivePattern(int row, int col, int[,] digits)
        {
            if (col > digits.GetLength(0) - 3 || row + 4 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row, col + 1] == 5 && digits[row, col + 2] == 5 && digits[row + 1, col] == 5 && digits[row + 2, col] == 5 &&
                digits[row + 2, col + 1] == 5 && digits[row + 2, col + 2] == 5 && digits[row + 3, col + 2] == 5 && digits[row + 4, col] == 5 &&
                digits[row + 4, col + 1] == 5 && digits[row + 4, col + 2] == 5)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }

        static int SixPattern(int row, int col, int[,] digits)
        {
            if (col > digits.GetLength(0) - 3 || row + 4 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row, col + 1] == 6 && digits[row, col + 2] == 6 && digits[row + 1, col] == 6 && digits[row + 2, col] == 6 &&
                digits[row + 2, col + 1] == 6 && digits[row + 2, col + 2] == 6 && digits[row + 3, col + 2] == 6 && digits[row + 3, col] == 6 &&
                digits[row + 4, col + 2] == 6 && digits[row + 4, col] == 6 && digits[row + 4, col + 1] == 6)
            {
                return 6;
            }
            else
            {
                return 0;
            }
        }

        static int SevenPattern(int row, int col, int[,] digits)
        {
            if (col > digits.GetLength(0) - 3 || row + 4 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row, col + 1] == 7 && digits[row, col + 2] == 7 && digits[row + 1, col + 2] == 7 && digits[row + 2, col + 1] == 7 &&
                digits[row + 3, col + 1] == 7 && digits[row + 4, col + 1] == 7)
            {
                return 7;
            }
            else
            {
                return 0;
            }
        }

        static int EightPattern(int row, int col, int[,] digits)
        {
            if (col > digits.GetLength(0) - 3 || row + 4 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row, col + 1] == 8 && digits[row, col + 2] == 8 && digits[row + 1, col + 2] == 8 && digits[row + 1, col] == 8 &&
                digits[row + 2, col + 1] == 8 && digits[row + 4, col + 2] == 8 && digits[row + 4, col] == 8 && digits[row + 4, col + 1] == 8 &&
                digits[row + 3, col] == 8 && digits[row + 3, col + 2] == 8)
            {
                return 8;
            }
            else
            {
                return 0;
            }
        }

        static int NinePattern(int row, int col, int[,] digits)
        {
            if (col > digits.GetLength(0) - 3 || row + 4 >= digits.GetLength(0))
            {
                return 0;
            }
            else if (digits[row, col + 1] == 9 && digits[row, col + 2] == 9 && digits[row + 1, col + 2] == 9 && digits[row + 1, col] == 9 &&
                digits[row + 2, col + 1] == 9 && digits[row + 2, col + 2] == 9 && digits[row + 4, col + 2] == 9 && digits[row + 4, col] == 9 &&
                digits[row + 4, col + 1] == 9 && digits[row + 3, col + 2] == 9)
            {
                return 9;
            }
            else
            {
                return 0;
            }
        }
    }
}
