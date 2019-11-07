using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3NewFeatures
{
    static class Extensions
    {
        public static int ToNumber(this string str)
        {
            return Convert.ToInt32(str);
        }

        public static bool Compare(this Customer customer1, Customer customer2)
        {
            if(customer1.CustomerId == customer2.CustomerId && customer1.Name == customer2.Name && customer1.City == customer2.City)
            {
                return true;
            }

            return false;
        }

        public static List<T> Append<T>(this List<T> a, List<T> b)
        {
            var newList = new List<T>(a);
            newList.AddRange(b);
            return newList;
        }
    }
}
