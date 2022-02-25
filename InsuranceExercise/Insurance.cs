

namespace InsuranceExercise
{
    class Insurance
    {
        private string species;
        private string name;
        private bool neutered;
        private double fee;
        public Insurance(string animal, string name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.fee = payment;
        }

        public string Animal { get { return species; } }
        public string Name { get { return name; } }

        public double Fee { get { return fee; } }
        public bool IsNeutered { get { return neutered; } }

        public string GetNeuteredInfo()                         
        {
            if (neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }
        public override string ToString()
        {
            return this.species + ": " + this.name + ", " + this.GetNeuteredInfo();
        }
    }
}
