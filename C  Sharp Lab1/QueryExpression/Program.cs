using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, };
            Console.WriteLine("Even numbers using normal iteration");
            foreach (int number in numbers)
            {
                if(number %2 == 0 ) {
                    Console.WriteLine(number);
                }
            }



            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;
            Console.WriteLine("Even numbers using LINQ query");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine($"{number}");
            }



            Console.WriteLine("Even numbers using Lambda Function");
            var evenNumbers2 = numbers.Where(n => n % 2 == 0);
            foreach (var number in evenNumbers2)
            {
                Console.WriteLine(number);
            }


            Console.ReadLine();
        }



    }
}
