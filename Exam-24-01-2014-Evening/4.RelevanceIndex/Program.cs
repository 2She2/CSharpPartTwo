using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.RelevanceIndex
{
    class Program
    {
        static void Main(string[] args)
        {

            string searchedWord = Console.ReadLine();
            int L = int.Parse(Console.ReadLine());
            string[] paragraphs = new string[L];
            int[] occ = new int[L];


            for (int i = 0; i < L; i++)
            {
                paragraphs[i] = Console.ReadLine();
                paragraphs[i] = Regex.Replace(paragraphs[i], @"\b" + searchedWord + @"\b", m => m.Result(searchedWord.ToUpper()), RegexOptions.IgnoreCase);
                MatchCollection matches = Regex.Matches(paragraphs[i], @"\b" + searchedWord + @"\b", RegexOptions.IgnoreCase);
                occ[i] = matches.Count;
                paragraphs[i] = Regex.Replace(paragraphs[i], @"[,|\.|-|!|?|)|(|;]", m => m.Result(""));
                //paragraphs[i] = Regex.Replace(paragraphs[i], @"\(", "\)", m => m.Result(" "));
                paragraphs[i] = Regex.Replace(paragraphs[i], @" +", m => m.Result(" "));


                //MatchCollection matches = Regex.Matches(paragraphs[i], @"\b" + searchedWord + @"\b", RegexOptions.IgnoreCase);
                //occ[i] = matches.Count;
            }

            Array.Sort(occ, paragraphs);


            for (int i = L - 1; i >= 0; i--)
            {
                Console.WriteLine(paragraphs[i]);
            }
        }
    }
}
