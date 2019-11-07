using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter employee id : ");
            //int id = Console.Read();
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Date of Birth : ");
            DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());

            //calculate age
            DateTime nowDate = DateTime.Now;
            int age = nowDate.Year - dateOfBirth.Year;

            Console.WriteLine($"The age is {age}");

        }
    }
}
