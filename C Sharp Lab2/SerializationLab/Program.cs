using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationLab
{
    class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book
            {
                BookId = 1,
                Name = "Song of Ice and Fire",
                Author = "GRRM",
                Price = 1400
            };

            //SerializeBinary(book);
            //DeserializeBinary();
            //SerializeXml(book);
            DeserializeXml();
            Console.ReadLine();
        }

        private static void DeserializeXml()
        {
            try
            {
                using (var stream = new FileStream(@"e:\bookinfo.xml", FileMode.Open, FileAccess.Read))
                {
                    var serializer = new XmlSerializer(typeof(Book));
                    var data = serializer.Deserialize(stream);
                    if (data is Book) //type check
                    {
                        var book = data as Book;
                        Console.WriteLine("Book Deserialized.");
                        Console.WriteLine($"Book Id : {book.BookId}\n Name : {book.Name}\n Author : {book.Author}\n Price : {book.Price}");

                    }

                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void SerializeXml(Book book)
        {
            try
            {
                using (var writer = XmlWriter.Create(new FileStream(@"e:\bookinfo.xml", FileMode.OpenOrCreate, FileAccess.Write)))
                {
                    var serializer = new XmlSerializer(typeof(Book));
                    serializer.Serialize(writer, book);

                    Console.WriteLine("XML serialization done!");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DeserializeBinary()
        {
            try
            {
                using(FileStream stream = new FileStream(@"e:\bookinfo.txt", FileMode.Open, FileAccess.Read))
                {
                    var formatter = new BinaryFormatter();
                    var data = formatter.Deserialize(stream);

                    if (data is Book) //type check
                    {
                        var book = data as Book;
                        Console.WriteLine("Book Deserialized.");
                        Console.WriteLine($"Book Id : {book.BookId}\n Name : {book.Name}\n Author : {book.Author}\n Price : {book.Price}");

                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void SerializeBinary(Book book)
        {
            try
            {
                using (FileStream stream = new FileStream(@"e:\bookinfo.txt", FileMode.OpenOrCreate, FileAccess.Write))
                {
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, book);

                    Console.WriteLine("Binary serialization done!");
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
