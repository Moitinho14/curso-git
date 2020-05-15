using System.Globalization;

namespace Taxes.Ententies
{
    class Individual : Contributors
    {
        public double HealthExpendiures { get; set; }
    
        public Individual()
        {
        }

        public Individual(double healthExpendiures, string name, double anualIncome)
            : base(name, anualIncome)
        {
            HealthExpendiures = healthExpendiures;
        }

        public override double TaxesPaid()
        {
            double taxa = 0.0;
            if (AnualIncome < 20000.0)
                taxa = 0.15;
            else
                taxa = 0.25;
            
            return (AnualIncome * taxa) - (HealthExpendiures * 0.5);

        }
    }
}
