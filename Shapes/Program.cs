using System;
using System.Collections.Generic;
using System.Linq;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shapes-tehtävä\n");
            List<Shape> allShapes = new List<Shape>
            {
                new Circle("red", 6),
                new Circle("blue", 2),
                new Triangle(4,7, "green"),
                new Triangle(8,12, "yellow"),
                new Rectangle(6,10, "black")

            };
            allShapes.Sort();
            Console.WriteLine("--Kaikkien muotojen tiedot");
            foreach(Shape s in allShapes)
            {
                Console.WriteLine($"{ s.GetInfo()}");
            }
            Console.WriteLine();
            Console.WriteLine("--Ympyröiden tiedot");
            foreach (Shape s in allShapes.Where(x => x.GetType() == typeof(Circle)))
            {
                Console.WriteLine($"{ s.GetInfo()}");
            }


        }
    }
}
