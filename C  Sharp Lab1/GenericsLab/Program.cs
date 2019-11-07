using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericClass<int> genericInt = new GenericClass<int>(4, 4);
            Console.WriteLine($"Addition Results: " + $"{genericInt.param1 + genericInt.param2 }");

            GenericClass<string> genericString = new GenericClass<string>("Hello", "World");
            Console.WriteLine($"Concatenation result :"+$"{genericString.param1 + genericString.param2}");
        }
    }
}
