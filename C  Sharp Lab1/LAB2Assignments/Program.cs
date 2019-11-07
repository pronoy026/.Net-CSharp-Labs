using EnumWeekDays;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Assignments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value between 1 to 7");
            WeekDays dayValue = (WeekDays) Convert.ToInt32(Console.ReadLine());

            switch (dayValue)
            {
                case WeekDays.Sunday:
                    Console.WriteLine($"The day of the week is {dayValue}");
                    break;
                case WeekDays.Monday:
                    Console.WriteLine($"The day of the week is {dayValue}");
                    break;
                case WeekDays.Tuesday:
                    Console.WriteLine($"The day of the week is {dayValue}");
                    break;
                case WeekDays.Wednesday:
                    Console.WriteLine($"The day of the week is {dayValue}");
                    break;
                case WeekDays.Thursday:
                    Console.WriteLine($"The day of the week is {dayValue}");
                    break;
                case WeekDays.Friday:
                    Console.WriteLine($"The day of the week is {dayValue}");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine($"The day of the week is {dayValue}");
                    break;
                default:
                    Console.WriteLine("Please enter a value within day range");
                    break;
            }
        }
    }
}
