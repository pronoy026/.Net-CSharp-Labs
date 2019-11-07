using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the range :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fibonacci series upto {n}th term : ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }
        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
    }
}
