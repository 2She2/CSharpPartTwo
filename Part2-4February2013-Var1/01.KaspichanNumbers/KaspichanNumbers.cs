namespace _01.KaspichanNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class KaspichanNumbers
    {
        static void Main()
        {
            // 100 Points

            List<ulong> List = new List<ulong>();

            ulong input = ulong.Parse(Console.ReadLine());
            ulong remainder;

            if (input == 0)
            {
                Console.WriteLine('A');
                return;
            }

            while (input > 0)
            {
                remainder = input % 256;
                List.Add(remainder);

                input /= 256;
            }

            for (int i = List.Count - 1; i >= 0; i--)
            {
                if (List[i] < 26)
                {
                    Console.Write("{0}", (char)(List[i] + 'A'));
                }
                else
                {
                    ulong prefix = List[i] / 26;
                    ulong suffix = List[i] % 26;

                    char small = (char)(prefix + 'a' - 1);
                    char big = (char)(suffix + 'A');

                    Console.Write("{0}{1}", small, big);
                }
            }
        }
    }
}
