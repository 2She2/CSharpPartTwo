// 15. Write a program that replaces in a HTML document given as string all the tags
//     <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:
//     <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course.
//     Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

//     <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course.
//    Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>


namespace _15.ReplaceHrefTag
{
    using System;
    using System.Text.RegularExpressions;

    class ReplaceHrefTag
    {
        static void Main()
        {
            string html = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string pattern = "<a href=\"(.*?)\">(.*?)</a>";

            // $1 is reference to first group "(.*?)" and $2 is reference to second group "(.*?)"
            string replacedHtml = Regex.Replace(html, pattern, "[URL=$1]$2[/URL]");

            Console.WriteLine(replacedHtml);
        }
    }
}
