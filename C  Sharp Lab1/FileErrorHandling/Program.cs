using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //file writing
            try
            {
                using (FileStream stream = new FileStream(@"e:\cognizant.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine("Hello");
                        writer.WriteLine("Uber");

                        Console.WriteLine("File write is completed");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message );
            }

            //file reading
            try
            {
                using (FileStream stream = new FileStream(@"e:\cognizant.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                        Console.WriteLine("File read complete.");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
