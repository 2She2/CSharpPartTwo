using System;

class SpecialValue
{
    static void Main()
    {
        // 100 Points

        short N = short.Parse(Console.ReadLine());
        string initialLines = string.Empty;
        string[][] splitLines = new string[N][];
        short[][] numbers = new short[N][];
        bool[][] isVisited = new bool[N][];

        for (short i = 0; i < N; i++)
        {
            initialLines = Console.ReadLine();
            splitLines[i] = initialLines.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            numbers[i] = new short[splitLines[i].Length];

            for (short j = 0; j < splitLines[i].Length; j++)
            {
                numbers[i][j] = short.Parse(splitLines[i][j]);
            }

            splitLines[i] = null;
        }

        short currentPath = 0;
        short currentSpecialNumber = 0;
        short maxspecialNumber = 0;

        short currentCol = 0;
        short row = 0;

        for (short col = 0; col < numbers[0].Length; col++)
        {
            InitializeBoolArray(isVisited, numbers);

            currentPath = 1;
            currentCol = col;
            row = 0;

            while (true)
            {
                if (isVisited[row][currentCol])
                {
                    break;
                }

                if (numbers[row][currentCol] < 0)
                {
                    currentSpecialNumber = (short)(currentPath + Math.Abs(numbers[row][currentCol]));

                    if (currentSpecialNumber > maxspecialNumber)
                    {
                        maxspecialNumber = currentSpecialNumber;
                    }
                    break;
                }

                currentPath++;
                isVisited[row][currentCol] = true;
                currentCol = numbers[row][currentCol];
                row++;

                if (row == numbers.Length)
                {
                    row = 0;
                }
            }
        }

        Console.WriteLine(maxspecialNumber);
    }

    static void InitializeBoolArray(bool[][] boolArray, short[][] numArray)
    {
        for (short i = 0; i < numArray.Length; i++)
        {
            boolArray[i] = new bool[numArray[i].Length];
        }
    }
}
