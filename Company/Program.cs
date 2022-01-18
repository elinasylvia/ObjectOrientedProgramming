using System;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company exercise");

            //Example
            Console.WriteLine("Example: Building class");
            Console.WriteLine("\n\nSchool");
            Building school = new Building();
            school.buildingYear = 1990;
            school.address = "Skinnarilankatu 36, 53850 Lappeenranta";
            school.PrintInfo();
            Console.WriteLine("school-olio: " + school.ToString());
            school.CalculateAge();

            Console.WriteLine("\n\nOffice");
            Building office = new Building("Marssitie 50, 53100 Lappeenranta", 2000);
            office.PrintInfo();
            Console.WriteLine("office-olio: " + school.ToString());
            office.CalculateAge();


            Console.WriteLine("\n\nPost Office");
            // create object using copy constructor
            Building postOffice = new Building(office);
            postOffice.PrintInfo();
            Console.WriteLine("postOffice-olio: " + school.ToString());
            postOffice.CalculateAge();
            

        }
    }
}
