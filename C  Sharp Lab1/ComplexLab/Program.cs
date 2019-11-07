using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);
            ComplexNumber c3 = c1 + c2;
            Console.WriteLine(c3);
        }

    }
}
