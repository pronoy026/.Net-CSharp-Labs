using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string> ();
            Console.WriteLine("Capacity :"+list1.Capacity);
            list1.Add("Dosa");
            list1.Add("Idli");
            list1.Add("Biriyani");
            list1.Add("Tea");
            list1.Add("Coffee");

            Console.WriteLine("Capacity :"+list1.Capacity);

            foreach (string item in list1)
            {
                Console.WriteLine($"Item {item }");
            }

            Console.WriteLine($"Count = {list1.Count}");

            list1.Clear();

            Console.WriteLine("capacity"+list1.Capacity);

            Console.WriteLine($"Count = {list1.Count}");
            Console.ReadLine();
        }
    }
}
