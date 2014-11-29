// 10. Write a program that converts a string to a sequence of C# Unicode character literals.
//     Use format strings. Sample input:
//     Hi!
//     Expected output:
//     \u0048\u0069\u0021

namespace _10.StringToUnicodeCharacters
{
    using System;
    using System.Text;

    class StringToUnicodeCharacters
    {
        static void Main()
        {
            string text = "Hi!";
            StringBuilder sb = new StringBuilder();

            ////We can directly print the unicode sequence
            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.Write("\\u{0:X4}", (int)text[i]);
            //}

            // Or append it to a string
            for (int i = 0; i < text.Length; i++)
            {
                sb.AppendFormat("\\u{0:X4}", (int)text[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
