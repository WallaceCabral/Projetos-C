//Parte principal do programa.
using System;
using System.Collections.Generic;
using EmpresaTerceirizada;
using EmpresaTerceirizada.Entities;
using System.Globalization;

List<Employee> list = new List<Employee>(); // criou a lista 

Console.Write("Enter The number of Emplyees: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Employee  #{i} data:");
    
    Console.Write("Outsourced (y/n)? ");
    char ch =char.Parse(Console.ReadLine());

    Console.Write("Name: ");
    string name = Console.ReadLine();

    Console.Write("Hours: ");
    int hours = int.Parse(Console.ReadLine());

    Console.WriteLine("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

    if(ch == 'y')
    {
        Console.Write("Additional charge: ");
        double additionalCharge = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
        list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
    }
    else
    {
        list.Add(new Employee(name, hours, valuePerHour));
    }

}
Console.WriteLine();
Console.WriteLine("Payments: ");
foreach(Employee emp in list)
{
    Console.WriteLine(emp.Name+ "- $ " + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
}
