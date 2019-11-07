using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLAB
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo ourFile = new FileInfo(@"e:\boot.txt");

            if(ourFile.Exists)
            {
                Console.WriteLine($" Filename : {ourFile.Name}");
                Console.WriteLine($"Path : {ourFile.FullName}");
                Console.WriteLine($"Length : {ourFile.Length}");
                //Console.WriteLine($"Data : {}");

                var allText = System.IO.File.ReadAllText(ourFile.FullName);
                Console.WriteLine(allText);
            }

            DirectoryInfo ourDir = new DirectoryInfo(@"e:");
            Console.WriteLine($"Directory: {ourDir.FullName}");
            foreach (var file in ourDir.GetFiles())
            {
                Console.WriteLine(file.Name);
            }

            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Drive : {drive.Name}");
                Console.WriteLine($"Type : {drive.DriveType}");
            }

            FileStream stream = File.Open(@"e:\csharp.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            //FileStream fileStream = new FileStream(@"e:", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            StreamWriter writer = new StreamWriter(stream);
            writer.WriteLine("Hi Console");
            writer.Close();
            stream.Close();

            stream = File.Open(@"e:\csharp.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            Console.WriteLine(content);
            reader.Close();
            stream.Close();

            MemoryStream memStrm = new MemoryStream();
            StreamWriter writer1 = new StreamWriter(memStrm);
            writer1.WriteLine("Hello");
            writer1.WriteLine("Hey there!");


            Console.ReadLine();
        }
    }
}
