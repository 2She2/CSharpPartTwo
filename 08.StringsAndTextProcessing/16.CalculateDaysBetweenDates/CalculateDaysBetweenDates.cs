// 16. Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//     Example:
//     Enter the first date: 27.02.2006
//     Enter the second date: 3.03.2004
//     Distance: 4 days

namespace _16.CalculateDaysBetweenDates
{
    using System;
    using System.Globalization;
    using System.Threading;

    class CalculateDaysBetweenDates
    {
        static void Main()
        {
            // Culture is set to "bg-BG", because "CultureInfo.InvariantCulture" is not working properly on my PC
            DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", new CultureInfo("bg-BG"));
            DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), "d.MM.yyyy", new CultureInfo("bg-BG"));

            TimeSpan days = secondDate - firstDate;
            Console.WriteLine("Days count: {0}", days.TotalDays);
        }
    }
}
