using System;
using System.Collections.Generic;
using System.Globalization;
using Taxes.Ententies;

namespace Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contributors> list = new List<Contributors>();
            double totalTaxes = 0.0;

            Console.Write("Enter the number of tax payers: ");
            int numbers = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numbers; i++) {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i') {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Individual(healthExpenditures, name, anualIncome));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    list.Add(new Company(employees, name, anualIncome));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID");
            foreach (Contributors cont in list)
            {
                cont.ToString();
                Console.WriteLine(cont.Name + ": $" + cont.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += cont.TaxesPaid();
            }
            
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
