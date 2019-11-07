using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            for (int i = 0; i < 4; i++)
            {
                stack.Push($"string {i}");
            }

            Console.WriteLine(stack.Count);
            foreach (string item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("popped"+stack.Pop());
            Console.ReadLine();

        }

    }
}
