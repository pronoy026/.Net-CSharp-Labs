using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;

            int j = i ?? 40; // null coalesce operator?? if i is null then 40 is assigned to j
            j = i.GetValueOrDefault(); //if i is null then 0 is assigned to j
            if (i.HasValue)
            {

            }
            if (i == null)
            {

            }
        }
    }
}
