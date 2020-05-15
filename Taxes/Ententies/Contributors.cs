using System;
using System.Collections.Generic;
using System.Text;

namespace Taxes.Ententies
{
    abstract class Contributors
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Contributors()
        {
        }

        public Contributors(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
    }
}
