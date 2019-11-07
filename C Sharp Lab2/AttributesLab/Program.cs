using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesLab
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DisplayAuthorInfo(typeof(BookSingleAuthor));
            DisplayAuthorInfo(typeof(BookNoAuthor));
            DisplayAuthorInfo(typeof(BookMultiAuthor));

            Console.ReadLine();
        }

        private static void DisplayAuthorInfo(Type type)
        {
            Console.WriteLine($"Author information for {type}");

            Attribute[] attrs = Attribute.GetCustomAttributes(type);

            foreach (Attribute attribute in attrs)
            {
                if(attribute is AuthorAttribute)
                {
                    AuthorAttribute a = (AuthorAttribute)attribute;
                    Console.WriteLine($"Author name {a.GetName()}, version {a.Version}");
                }
            }
        }
    }
}
