﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetTuple();
        }

        static Tuple<int, string> GetTuple()
        {
            //Two ways of creating tuple
            var result = new Tuple<int, string>(12, "Hello");
            var res = Tuple.Create<int, string>(12, "Hello");

            return result;

        }
    }
}
