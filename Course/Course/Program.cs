using System;
using System.Globalization;
using System.Xml.Schema;
using Course.Entities;
using Course.Entities.Enums;


Console.WriteLine("Enter department's name:");
string deptName = Console.ReadLine();

Console.WriteLine("Enter worker data:");
Console.Write("Name: ");
string name =Console.ReadLine();

Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

Console.Write("Base salary: ");
double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

Departament dept = new Departament(deptName);
Worker worker = new Worker(name, level, salary, dept);

Console.WriteLine("How many contracts to this worker?");
int n = int.Parse(Console.ReadLine());

//Leitura de quantos contratos serão lidos
for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    
    Console.Write("Date (DD/MM/YYYY):");
    DateTime date = DateTime.Parse(Console.ReadLine());
    
    Console.Write("Value per hour: ");
    double valuePerHour = int.Parse(Console.ReadLine());

    Console.Write("Duration (hours):");
    int hour = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date,valuePerHour,hour);
    worker.AddContract(contract);
 }

Console.WriteLine();
Console.Write("Enter month and year to calculate income (MM/YYYY):");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));

Console.Write("Name: "+worker.Name);
Console.WriteLine("Departament: " + worker.Departament.Name );
Console.WriteLine("Income for: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));

