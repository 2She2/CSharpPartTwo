using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.FakeTextMarkupLanguage
{
    class FakeTextMarkupLanguage
    {
        static void Main()
        {
            // 100 Points

            int N = int.Parse(Console.ReadLine());
            string[] lines = new string[N];
            StringBuilder wholeText = new StringBuilder(1000);

            for (int i = 0; i < N; i++)
            {
                wholeText.Append(Console.ReadLine());

                if (i < N - 1)
                {
                    wholeText.Append("\n");
                }
            }

            string pattern = @"(<\w+>)([^<>]*?)(</\w+?>)";

            while (true)
            {
                Match match = Regex.Match(wholeText.ToString(), pattern);

                if (match.Success)
                {
                    string m = match.Groups[1].Value;

                    switch (m)
                    {
                        case "<upper>":
                            wholeText.Replace(match.Value, match.Groups[2].Value.ToUpper());
                            break;
                        case "<lower>":
                            wholeText.Replace(match.Value, match.Groups[2].Value.ToLower());
                            break;
                        case "<toggle>":
                            StringBuilder repl = new StringBuilder(match.Groups[2].Value);

                            for (int j = 0; j < repl.Length; j++)
                            {
                                if (char.IsLower(repl[j]))
                                {
                                    repl[j] = char.ToUpper(repl[j]);
                                }
                                else
                                {
                                    repl[j] = char.ToLower(repl[j]);
                                }
                            }

                            wholeText.Replace(match.Value, repl.ToString());
                            break;
                        case "<rev>":
                            char[] array = match.Groups[2].Value.ToCharArray();
                            Array.Reverse(array);
                            string charArrToStr = new string(array);
                            wholeText.Replace(match.Value, charArrToStr);
                            break;
                        case "<del>":
                            wholeText.Replace(match.Value, string.Empty);
                            break;
                        default: throw new ArgumentOutOfRangeException();
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(wholeText.ToString());
        }
    }
}
