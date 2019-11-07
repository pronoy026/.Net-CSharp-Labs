using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialType
{
    class Program
    {
        static void Main(string[] args)
        {
            customer customer1 = new customer();
            customer1.minus();
            Helper.Log("This is it");
        }
    }
}
