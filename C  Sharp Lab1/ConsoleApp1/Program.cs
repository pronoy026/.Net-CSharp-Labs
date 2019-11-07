using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    class Program
    {
        static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer(1) { Name = "Tanisk", City = "Ahmedabad"},
                new Customer(2) { Name = "Richa", City= "Kolkata"},
                new Customer(3) { Name = "Kaira", City = "Jaipur"},
                new Customer(4) { Name = "Hemant", City= "Siliguri"},
                new Customer(5) { Name = "Kaizer", City= "Kolkata"},
                new Customer(6) { Name = "Lisa", City= "Kolkata"}
            };

            return customers;
        }
        static void Main(string[] args)
        {
            var filePath1 = @"e:\customers1.xml";
            var filePath = @"e:\customers.xml";

            //try
            //{
            //    using (XmlWriter writer = XmlWriter.Create(filePath))
            //    {
            //        writer.WriteStartDocument();
            //        writer.WriteStartElement("Customers");

            //        foreach (var customer in GetCustomers())
            //        {
            //            //writer.WriteStartElement("Customer");
            //            //writer.WriteElementString("CustomerId", customer.CustomerId.ToString());
            //            //writer.WriteElementString("Name", customer.Name);
            //            //writer.WriteElementString("City", customer.City);

            //            writer.WriteStartElement("Customer");
            //            writer.WriteAttributeString("CustomerId", customer.CustomerId.ToString());
            //            writer.WriteAttributeString("Name", customer.Name);
            //            writer.WriteAttributeString("City", customer.City);


            //            writer.WriteEndElement();
            //        }

            //        writer.WriteEndElement();
            //        writer.WriteEndDocument();
            //    }
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            //Console.WriteLine("Xml created successfully");
            ReadCustomerXmlFile(filePath);
            ReadCustomerXmlFile(filePath1);
            Console.ReadLine();
        }

        private static void ReadCustomerXmlFile(string filepath)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(filepath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n"+filepath+"\n");
            var customerNodes = document.GetElementsByTagName("Customer");

            foreach (XmlNode customer in customerNodes)
            {
                if (customer.Attributes.Count > 0)
                {
                    foreach (XmlAttribute attribute in customer.Attributes)
                    {
                        Console.WriteLine($"{attribute.Name} : {attribute.InnerText}");
                    }
                } else
                {
                    foreach (XmlNode node in customer.ChildNodes)
                    {
                        Console.WriteLine($"{node.Name} : {node.InnerText}");
                    }
                }
            }
        }
    }
}
