using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Burke", "Conner", "Frank", "Everett", "Albert", "George", "Harris", "David", "Alfonzo" };
            List<string> msg = new List<string> { "Hello World", "Hello LINQ", "Goodbye LINQ" };

            //var selectedList = from m in msg
            //                   where m.EndsWith("LINQ")
            //                   select m;

            var selectedList = msg.Where(m => m.EndsWith("LINQ")).Select(m => m);
            Console.WriteLine("Words ending with LINQ : ");
            foreach (var m in selectedList)
            {
                Console.WriteLine(m);
            }

            //var result = from n in names
            //             where n.Length == 5
            //             select n.ToUpper();

            var result = names.Where(n => n.Length == 5).Select(n => n.ToUpper());

            //var AorB = from n in names
            //           where n.StartsWith("A") || n.StartsWith("B")
            //           orderby n descending
            //           select n;
            var AorB = names.Where(n => n.StartsWith("A") || n.StartsWith("B")).OrderBy(s => s).Select(n => n);


            Console.WriteLine("\nNames starting with A or B : ");
            foreach (var name in AorB)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\nNames Having 5 letters : ");
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine(Console.ReadLine());
        }
    }
}
