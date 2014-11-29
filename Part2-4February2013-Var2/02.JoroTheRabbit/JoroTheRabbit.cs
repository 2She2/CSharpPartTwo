using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.JoroTheRabbit
{
    class JoroTheRabbit
    {
        static void Main()
        {
            // 100 Points

            string inputStr = Console.ReadLine();
            string[] chars = inputStr.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[chars.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(chars[i]);
            }

            int iniIndex = 0;
            int currentNumber = -1001;
            int maxSteps = 1;

            while (true)
            {
                int step = 1;
                currentNumber = numbers[iniIndex];

                while (true)
                {
                    int currentStep = CalcIndexInBounds(step, numbers.Length, iniIndex);

                    if (currentNumber < numbers[currentStep])
                    {
                        int stepsCount = CountSteps(currentNumber, numbers, step, iniIndex);

                        if (stepsCount > maxSteps)
                        {
                            maxSteps = stepsCount;
                        }
                    }

                    step++;

                    if (step == numbers.Length)
                    {
                        break;
                    }
                }

                iniIndex++;

                if (iniIndex == numbers.Length)
                {
                    break;
                }
            }

            Console.WriteLine(maxSteps);
        }

        static int CountSteps(int currentNum, int[] nums, int step, int index)
        {
            int stepsCount = 1;

            while (true)
            {
                index = CalcIndexInBounds(step, nums.Length, index);

                if (currentNum < nums[index])
                {
                    currentNum = nums[index];
                    stepsCount++;
                }
                else
                {
                    break;
                }
            }

            return stepsCount;
        }

        static int CalcIndexInBounds(int step, int arrLength, int index)
        {
            if (step + index >= arrLength)
            {
                step = step - (arrLength - index);
            }
            else
            {
                step += index;
            }

            return step;
        }
    }
}
