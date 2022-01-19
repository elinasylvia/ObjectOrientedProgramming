using System;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company exercise");

            Company kahvila = new Company("Kissakahvila / Leipomo Katinhäntä", "Valtakatu 30, 53100 Lappeenranta", 0401234567, 9546.56, 3465.09);
            kahvila.CompanySummary();
            kahvila.FinancialSituation();
            Company leipomo = new Company(kahvila);
            leipomo.CompanySummary();
            leipomo.FinancialSituation();
            Company kirpputori = new Company("KirppuTori", "Ratakatu 2, 53120 Lappeenranta", 097564321, 116754.34, 2436.32 );
            kirpputori.CompanySummary();
            kirpputori.FinancialSituation();
            


















            //Example
            //Console.WriteLine("Example: Building class");
            //Console.WriteLine("\n\nSchool");
            //Building school = new Building();
            //school.buildingYear = 1990;
            //school.address = "Skinnarilankatu 36, 53850 Lappeenranta";
            //school.PrintInfo();
            //Console.WriteLine("school-olio: " + school.ToString());
            //school.CalculateAge();

            //Console.WriteLine("\n\nOffice");
            //Building office = new Building("Marssitie 50, 53100 Lappeenranta", 2000);
            //office.PrintInfo();
            //Console.WriteLine("office-olio: " + school.ToString());
            //office.CalculateAge();


            //Console.WriteLine("\n\nPost Office");
            //// create object using copy constructor
            //Building postOffice = new Building(office);
            //postOffice.PrintInfo();
            //Console.WriteLine("postOffice-olio: " + school.ToString());
            //postOffice.CalculateAge();


        }
    }
}
