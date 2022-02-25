using System;
using System.Collections.Generic;


namespace InsuranceExercise
{
    class InsuranceManager
    {
        public InsuranceManager()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
        }

        private List<Insurance> insurances = new List<Insurance>();
    public void AddInsurance(string animal, string name, bool isNeutered)
        {
            double payment = GetFee(animal, isNeutered);
            Insurance insurance = new Insurance(animal, name, isNeutered, payment);
            insurances.Add(insurance);
        }
        public double GetFee(string species, bool isNeutered)
        {
            double fee = 0;
            if (isNeutered)
            {
                if (species == "Koira")
                {
                    fee = 50;
                }
                else if (species == "Kissa")
                {
                    fee = 40;
                }
            }
            else
            {
                if (species == "Koira")
                {
                    fee = 80;
                }
                else if (species == "Kissa")
                {
                    fee = 60;
                }

            }
            return fee;
        }

        public void PrintInsurances()
        {
            Console.WriteLine($"vakuutuksia yhteensä {insurances.Count}\n");
            Console.WriteLine($"vakuutukset:\n");
            insurances.ForEach(insurance => Console.WriteLine($"  {insurance}\n"));
        }

        public void FindInsurances(string animal, bool isNeutered)
        {
            Console.WriteLine("---\n\nlöytyi:\n");
            var found = insurances.FindAll(insurance => insurance.Animal == animal && insurance.IsNeutered == isNeutered);
                
            found.ForEach(insurance => Console.WriteLine($"  {insurance.Animal}: {insurance.Name}, vakuutusmaksu {insurance.Fee} €\n"));
        }
    }
}
