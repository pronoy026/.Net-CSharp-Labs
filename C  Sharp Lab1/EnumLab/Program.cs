using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumLab
{
    enum Color : byte
    {
        Red = 1,
        Green = 2,
        Blue = 4,
        Black = 0,
        White = Red | Green | Blue
    }
    class Program
    {
        static void Main(string[] args)
        {
            Color c = Color.Black;
            Console.WriteLine(c);
        }
    }
}
