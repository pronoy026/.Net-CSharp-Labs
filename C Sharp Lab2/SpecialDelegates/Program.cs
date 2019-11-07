using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Action and Func
            //Action welcome = () =>
            //{

            //};  when no parameter specified

            Action<string> welcome = (name2) =>
           {
               Console.WriteLine($"Hello {name2}");
           };

            welcome("Pronoy");

            Func<string, string, string> getName = (firstName, lastName) =>
            {
                return $"{firstName} {lastName}";
            };

            var name = getName("Pronoy", "Sarkar");
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
}
