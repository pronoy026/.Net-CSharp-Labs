using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass array = new ArrayClass(3);
            Console.WriteLine(array.GetItem(4));
            Console.ReadLine();
        }
    }
}
