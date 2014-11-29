using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.Brackets2
{
    class Brackets
    {
        static void Main(string[] args)
        {
            // 100 Points

            int linesCount = int.Parse(Console.ReadLine());
            string indentation = Console.ReadLine();
            string[] code = new string[linesCount];

            for (int i = 0; i < linesCount; i++)
            {
                code[i] = Console.ReadLine();
                code[i] = Regex.Replace(code[i], @"( )\1+", "$1");
                code[i] = Regex.Replace(code[i], "( )*{( )*", m => m.Result("{"));
                code[i] = Regex.Replace(code[i], "( )*}( )*", m => m.Result("}"));
                code[i] = code[i].Trim();
            }

            StringBuilder sb = new StringBuilder(100);

            for (int i = 0; i < code.Length; i++)
            {
                sb.Append(code[i]);
                if (i < code.Length - 1)
                {
                    sb.Append("\n");
                }
            }

            string str = Regex.Replace(sb.ToString(), @"(\n)?{", m => m.Result("\n{"));
            str = Regex.Replace(str, @"{(\n)?", m => m.Result("{\n"));

            str = Regex.Replace(str, @"(\n)?}", m => m.Result("\n}"));
            str = Regex.Replace(str, @"}(\n)?", m => m.Result("}\n"));

            string[] lines = str.Split(new char[] { (char)10 }, StringSplitOptions.RemoveEmptyEntries);

            int bracketsCount = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i][0] == '}')
                {
                    bracketsCount--;
                }

                Console.Write(AppendIndentation(bracketsCount, indentation));
                Console.WriteLine(lines[i]);

                if (lines[i][0] == '{')
                {
                    bracketsCount++;
                }
                
            }
        }

        static string AppendIndentation(int bracketsCount, string indentation)
        {
            StringBuilder sb = new StringBuilder();

            for (int b = 0; b < bracketsCount; b++)
            {
                sb.Append(indentation);
            }

            return sb.ToString();
        }
    }
}
