// 17. Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//     and prints the date and time after 6 hours and 30 minutes (in the same format)
//     along with the day of week in Bulgarian.

namespace _17.DayOfWeekAndTimeAfter
{
    using System;
    using System.Globalization;
    using System.Threading;

    class DayOfWeekAndTimeAfter
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");

            //string dateString = Console.ReadLine();
            string dateString = "18.01.2006 11:05:20";

            DateTime date = DateTime.ParseExact(dateString, "d.MM.yyyy HH:mm:ss", new CultureInfo("bg-BG"));
            date = date.AddHours(6.5);

            Console.WriteLine(date);
            Console.WriteLine(date.ToString("dddd"));
        }
    }
}
