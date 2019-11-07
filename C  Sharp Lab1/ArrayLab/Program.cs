using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter array values");
            for (int index = 0; index < 5; index++)
            {
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }

            for (int index = 0; index < 5; index++)
            {
                Console.WriteLine(arr[index]);
            }
            foreach (int value in arr)
            {
                Console.Write(value+"\t");
            }
        }
    }
}
