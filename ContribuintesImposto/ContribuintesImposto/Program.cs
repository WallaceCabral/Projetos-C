using System;
using System.Collections.Generic;
using System.Globalization;
using ContribuintesImposto.Entities;


List<TaxPayer> list = new List<TaxPayer>();

Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.Write($"Tax payer #{i} data: ");

    Console.Write("Individual or company (i/c)?");
    char type = char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine());

    if (type == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new Individual(name, income, healthExpenditures));

    }
    else
    {
        Console.Write("Number of employees: ");
        int numberEmployer = int.Parse(Console.ReadLine());
        list.Add(new Company(name, income, numberEmployer));
    }
}

    double sum = 0.0;
    Console.WriteLine();
    Console.WriteLine("TAXES PAID:");
    foreach (TaxPayer tp in list)
    {
        double tax = tp.Tax();
        Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
        sum += tax;
    }

    Console.WriteLine();
    Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));


