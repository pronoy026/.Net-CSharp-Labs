using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In main: starting thread");
            Thread childThread = new Thread(childMethod);
            childThread.Name = "Child Thread";
            childThread.Start();

            Thread.Sleep(3000);
            Console.WriteLine("In Main : Aborting child thread");
            childThread.Abort();
            Console.WriteLine("In Main : child threas aborted");
            Console.ReadLine();
        }

        private static void childMethod()
        {
            try
            {
                Console.WriteLine("In child thread");

                for (int counter = 0; counter < 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("Child thread completed.");
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
