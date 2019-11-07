using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            for (int i = 0; i < 4; i++)
            {
                queue.Enqueue($"string{i}");
            }
            foreach (string item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Element count : {queue.Count}");
            Console.WriteLine($"Popped item : {queue.Dequeue()}");
            Console.ReadLine();
        }
    }
}
