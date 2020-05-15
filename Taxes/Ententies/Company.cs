using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Taxes.Ententies
{
    class Company : Contributors
    {
        public int Employees { get; set; }

        public Company()
        {
        }

        public Company(int employees, string name, double anualIncome)
            : base(name, anualIncome)
        {
            Employees = employees;
        }

        public override double TaxesPaid()
        {
            double taxa = 0.0;

            if (Employees > 10)
                taxa = 0.14;
            else
                taxa = 0.16;

            return AnualIncome * taxa;
        }
    }
}
