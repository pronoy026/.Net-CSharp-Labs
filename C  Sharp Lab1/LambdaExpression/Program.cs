using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new List<Point>()
            {
                new Point { X= 12, Y=10 },
                new Point { X= 11, Y=9 },
                new Point { X= 10, Y=8 },
                new Point { X= 9, Y=7 },
                new Point { X= 8, Y=6 }
            };
            Console.WriteLine("Anonymous method C# 2.0 feature");
            var filteredPoints = points.FindAll(delegate (Point p)
            {
                return p.X > 0 && p.Y > 0;
            });

            foreach (var point in filteredPoints)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("Using Lambda Expression C# 3.0 feature");

            var filteredPoints2 = points.FindAll(p => p.X > 0 && p.Y > 0);
            foreach (var point in filteredPoints2)
            {
                Console.WriteLine(point);
            }

            Console.WriteLine("Ascending sort Using Lambda Expression C# 3.0 feature");

            var filteredPoints3 = points.FindAll(p => p.X > 0 && p.Y > 0).OrderBy(p => p.X);
            foreach (var point in filteredPoints3)
            {
                Console.WriteLine(point);
            }

            Console.ReadLine();
        }
    }
}
