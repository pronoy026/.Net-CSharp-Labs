using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashtableLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();

            for (int i = 0; i < 4; i++)
            {
                hashtable.Add(i + 1, $"string {i + 1}"); //Add function
            }

            hashtable[65] = "string 65"; // Manual entry

            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"key = {item.Key} and value = {item.Value}");
            }

            ICollection valueCell = hashtable.Values;

            foreach (string str in valueCell)
            {
                Console.WriteLine($"value = {str}");
            }

            ICollection keyCell = hashtable.Keys;

            foreach (int key in keyCell)
            {
                Console.WriteLine($"key = {key}");
            }

            hashtable.Remove(1);
            if (!hashtable.ContainsKey(1))
            {
                Console.WriteLine(" The element having key 1 is not found");
            }

            Console.ReadLine();

        }
    }
}
