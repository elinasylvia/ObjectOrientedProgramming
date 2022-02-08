using System;
using System.Collections.Generic;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird("Keijo", 5, "BIRD", 2));
            birds.Add(new Bird("Reijo", 7, "BIRD", 2));
            birds.Add(new Bird("Kaija", 4, "BIRD", 2));
            birds.Add(new Bird("Raija", 2, "BIRD", 2));

            foreach(Bird b in birds)
            {
                Console.WriteLine(b.ToString());
            }
            birds.Sort();

            Console.WriteLine("Järjestetty lista");
            foreach (Bird b in birds)
            {
                Console.WriteLine(b.ToString());
            }

            //Console.WriteLine("Periytyminen");
            //Bird birdA = new Bird("Ankka", 5, "BIRD", 2);
            //Bird birdB = new Bird("Kaija", 10, "BIRD", 2);
            ////birdB.PrintInfo();
            //Console.WriteLine(birdB.ToString());

            //if (birdA.Equals(birdB))
            //{
            //    Console.WriteLine($"{birdA.GetName()} ja {birdB.GetName()} ovat samoja lintuja");
            //}
            //else
            //{
            //    Console.WriteLine($"{birdA.GetName()} ja {birdB.GetName()} eivät ole samoja lintuja");

            //}

            //Parrot parrotA = new Parrot ("Ara-papukaija","Kaija", 10, "BIRD", 2);
        }
    }
}
