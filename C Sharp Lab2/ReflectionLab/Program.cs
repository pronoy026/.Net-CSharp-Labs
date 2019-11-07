using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly info = typeof(System.Int32).Assembly;
            Console.WriteLine(info.FullName);

            Assembly assembly = Assembly.GetExecutingAssembly();
            ShowAssemblyName(assembly);
            ShowAssemblyTypes(assembly);

            Console.ReadLine();
        }

        private static void ShowAssemblyName(Assembly assembly)
        {
            Console.WriteLine($"Assembly name : {assembly.FullName}");
        }

        private static void ShowAssemblyTypes(Assembly assembly)
        {
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine(type);
                ShowMethods(type);
            }
        }

        private static void ShowMethods(Type type)
        {
            MethodInfo[] methodInfos = type.GetMethods();
            foreach (MethodInfo methodInfo in methodInfos)
            {
                Console.WriteLine($"\tMethod Name : {methodInfo.Name}");
            }
        }
    }
}
