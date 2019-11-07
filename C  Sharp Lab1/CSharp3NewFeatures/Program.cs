using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3NewFeatures
{
    class Program
    {

        //private int id;

        //public int id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //public int id { get; set; }
        //public string Name { get; set; }
        //public DateTime DateOfBirth { get; set; } for example 

        static List<Customer> GetCustomers()     //List Initializers
        {
            //string num = "123";
            //int result = num.ToNumber();    Extension
            //Console.WriteLine(result);



            //var customers = new List<Customer>()  
            List<Customer> customers = new List<Customer>()
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

        static List<Store> GetStores()     //List Initializers
        {
            List<Store> stores = new List<Store>()
            {
                new Store() { Name ="Dominos", City ="New York"},
                new Store() { Name = "Pizza Hut", City = "Siliguri"},
                new Store() { Name = "Homely", City = "Jaipur"},
                new Store() { Name ="Godrej", City = "Kolkata"},
                new Store() { Name ="Sony", City = "Kolkata"},
                new Store() { Name ="Samsung", City = "Kolkata"}
            };

            return stores;
        }

        static List<Customer> FindCustomersByCity(string city)
        {
            var customers = GetCustomers().FindAll(c=> c.City == city);
            return customers;
        }
        static void Main(string[] args)
        {
            //Customer customer = new Customer(56);
            //customer.Name = "Pronoy";
            //customer.City = "Kolkata";
            var george = 90;
            Customer customer = new Customer(3)  // here id is passes because  set accessor of id is set to private
            {
                Name = "Kaira",
                City = "Naiobi"
            };

            foreach (var customer1 in GetCustomers())
            {
                if (customer.Compare(customer1))
                {
                    Console.WriteLine("Customer already exists");
                }
                else
                {
                    Console.WriteLine("Not matched "+ customer1);
                }
            }

            var newList = new List<Customer>()
            {
                new Customer(59) { Name = "Rajesh", City = "Jaipur"},
                new Customer(588) { Name = "Deep", City = "Mumbai"}
            };

            var appendedList = GetCustomers().Append(newList);

            foreach (var item in appendedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nAll stores");
            foreach (var item in GetStores())
            {
                Console.WriteLine(item);
            }

            // Quiries**************************************************

            var allStores = GetStores();
            var queryCity = "Kolkata";
            var storeCount = (from s in allStores
                              where s.City == queryCity
                              select s).Count();

            Console.WriteLine($"Store count of city {queryCity} is : {storeCount}");


            Console.WriteLine("Find All Customers by Query City : ");
            var customersByCity = FindCustomersByCity(queryCity);
            foreach (var c in customersByCity)
            {
                Console.WriteLine(c);
            }

            //customer stores

            Console.WriteLine("\n\n\n\n");

            var customerStores = from c in GetCustomers()
                                 select new
                                 {
                                     c.Name,
                                     c.City,
                                     Stores = from s in GetStores()
                                              where s.City == c.City
                                              select s
                                 };
            Console.WriteLine("Customer with city info\n");
            foreach (var c in customerStores)
            {
                Console.WriteLine($"Name : {c.Name} City : {c.City}");
                int i = 1;
                foreach (var s in c.Stores)
                {
                    Console.WriteLine($"Store name {i} : {s.Name}");
                    i++;
                }
                Console.WriteLine("\n");
            }
                

            Console.ReadLine();
        }
    }
}
