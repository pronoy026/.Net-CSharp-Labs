using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3NewFeatures
{
    class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int CustomerId { get; private set; }

        public Customer( int customerId)
        {
            CustomerId = customerId;
        }
        public override string ToString()
        {
            return $"Id : {CustomerId}\t Name : {Name}\t City : {City}";
        }
    }
}
