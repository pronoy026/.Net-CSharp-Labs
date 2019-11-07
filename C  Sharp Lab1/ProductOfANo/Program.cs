using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfANo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int n1 = n, i, remainder, result =1;
            while (n1>0)
            {
                remainder = n1 % 10;
                result = result * remainder;
                n1 = n1 / 10;
            }
            Console.WriteLine($"The product of the digits is {result}");

            Console.WriteLine("Enter a no : ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            while(n3>0)
            {
                remainder = n3 % 10;
                if (remainder %2 ==0)
                {
                    Console.WriteLine($"even {remainder}");
                } else
                {
                    Console.WriteLine($"odd {remainder}");
                }
                n3 = n3 / 10;
            }
        }
    }
}
