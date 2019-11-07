using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    public delegate void MathDelegate(int num1, int num2);
    class Program
    {
        static void Main(string[] args)
        {
            MathDelegate mathDelegate1 = MathOps.Addition;
            MathDelegate mathDelegate2 = MathOps.Substraction;
            MathDelegate mathDelegate3 = MathOps.Multiply;
            MathDelegate mathDelegate4 = MathOps.Division;

            //multicast delegate
            MathDelegate mathDelegate = mathDelegate1;
            mathDelegate += mathDelegate2;
            mathDelegate += mathDelegate3;
            mathDelegate += mathDelegate4;

            mathDelegate(10, 20);
            Console.ReadLine();
        }
    }
}
