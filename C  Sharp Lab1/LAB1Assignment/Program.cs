using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 6, reversedNumber, r, n1, count=0;
            for (int i = 1; i <=n ; i++)
            {
                Console.WriteLine(i);
            }

            n = Convert.ToInt32(Console.ReadLine());
            n1 = n;
            reversedNumber = 0;

            // reversing
            while(n1>0)
            {
                count++;
                r = n1 % 10;
                reversedNumber = reversedNumber * 10 + r;
                n1 = n1 / 10;
            }
            Console.WriteLine("The reversed no is : " +reversedNumber);
            // 
            Console.WriteLine("No of Digits : " +count);

            int [] arr = new int[10];
            int sumOfArray = 0;

            for (int i = 0; i <arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                sumOfArray = sumOfArray + arr[i];
            }

            int avg = sumOfArray / arr.Length;
            Console.WriteLine("Average is : "+ avg);
            Console.ReadLine();

            int evenTwenty = 0;
            for (int i = 0; i <= 20  ; i++)
            {
                if (i%2 ==0)
                {
                    evenTwenty = evenTwenty + i;
                }

            }
            Console.WriteLine("Even no sum upto 20 is : " + evenTwenty);

            //if a given no exists or not
            string n2;
            string digit;
            Console.WriteLine("Enter a number : ");
            n2 = Console.ReadLine();
            Console.WriteLine("Enter a digit : ");
            digit = Console.ReadLine();
            if ( n2.Contains(digit)) {
                Console.WriteLine("Digit Exists in number");
            }
            else
            {
                Console.WriteLine("No does not contain the digit");
            }

        }
    }
}
