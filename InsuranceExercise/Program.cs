using System;

namespace InsuranceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            InsuranceManager im = new InsuranceManager();
            im.AddInsurance("Koira", "Rolle", false);
            im.AddInsurance("Koira", "Tessu", true);
            im.AddInsurance("Kissa", "Monni", true);
            im.AddInsurance("Koira", "Pluto", false);
            im.AddInsurance("Lintu", "Tipi", false);
            im.PrintInsurances();
            im.FindInsurances("Koira", false);

        }
    }
}
