using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfWeek days = new DaysOfWeek();

            foreach ( string day in days)
            {
                Console.WriteLine(day);
            }

            foreach (string day in GetDaysOfWeek())
            {
                Console.WriteLine(day);
            }

            Console.ReadLine();
        }


        //enumerable in a method
        private static IEnumerable<string> GetDaysOfWeek()
        {
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat" };

            for (int i = 0; i < days.Length; i++)
            {
                yield return days[i]; //yield prevents returning of control until loop ends
            }
        }
    }
} 
