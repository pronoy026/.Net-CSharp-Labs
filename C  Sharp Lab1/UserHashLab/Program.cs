using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHashLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable usertable = new Hashtable();

            for (int i = 0; i < 10; i++)
            {
                usertable.Add(i + 1, $"user { i + 1}");
            }
            Console.WriteLine("Please enter user Id :");
            int userId = Convert.ToInt32(Console.ReadLine());
            if(usertable.ContainsKey(userId))
            {
                Console.WriteLine($"The corresponding user name is {usertable[userId]}");
            } else
            {
                Console.WriteLine("Sorry! user not found");
            }
            Console.ReadLine();
        }
    }
}
