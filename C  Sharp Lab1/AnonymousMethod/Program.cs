using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{

    public delegate void WelcomeDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //WelcomeDelegate welcomeDelegate = new WelcomeDelegate(WelcomeMethod);

            //WelcomeDelegate welcomedelegate2 = WelcomeMethod;

            WelcomeDelegate welcome = delegate (string name)  //Anonymous Method
            {
                Console.WriteLine($"Hello{name}");
            };
        }

        private static void WelcomeMethod(string name)
        {
            Console.WriteLine($"Hello{name}");
        }
    }
}
