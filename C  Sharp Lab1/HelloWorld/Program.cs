using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " +name + ", Welcome to CTS!");
            Console.WriteLine(string.Format("Hello {0}, Welcome to CTS! ", name));
            Console.WriteLine($"Hello {name}, Welcome to CTS!"); //string interpolation
        }
    }
}
