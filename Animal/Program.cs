using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Periytyminen");
            Bird birdA = new Bird("Ankka", 5, "BIRD", 2);
            Bird birdB = new Bird("Kaija", 10, "BIRD", 2);
            //birdB.PrintInfo();
            Console.WriteLine(birdB.ToString());

            if (birdA.Equals(birdB))
            {
                Console.WriteLine($"{birdA.GetName()} ja {birdB.GetName()} ovat samoja lintuja");
            }
            else
            {
                Console.WriteLine($"{birdA.GetName()} ja {birdB.GetName()} eivät ole samoja lintuja");
                
            }

            Parrot parrotA = new Parrot ("Ara-papukaija","Kaija", 10, "BIRD", 2);
        }
    }
}
