using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDictionaryLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> userDictionary = new Dictionary<int, string>();
            for (int i = 0; i < 5; i++)
            {
                userDictionary.Add(i + 1, $"User {i+1}");
            }

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter user Id");
                
            }

            Console.WriteLine("Enter User ID");
            int userId = Convert.ToInt32(Console.ReadLine());
            if (userDictionary.ContainsKey(userId))
            {
                Console.WriteLine($"The corresponding user name is {userDictionary[userId]}");
            }
            else
            {
                Console.WriteLine("Sorry! user not found");
            }
            Console.ReadLine();
        }
    }
}
