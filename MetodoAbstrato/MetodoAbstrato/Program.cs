﻿using MetodoAbstrato.Entities;
using System;
using MetodoAbstrato.Entities.Enums;
using System.Globalization;

List<Shape> list = new List<Shape>();

Console.WriteLine("Enter the number of Shapes: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Shape #{i} data: ");
    Console.Write("Rectangle or Circle (r/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Color (Black/Blue/Red): ");
    Color color = Enum.Parse<Color>(Console.ReadLine());

    if (ch == 'r')
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Rectangle(width, height, color));
    }
    else
    {
        Console.Write("Radius: ");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        list.Add(new Circle(color, radius));
    }
}

Console.WriteLine();

Console.WriteLine("Shape Areas: ");
foreach (Shape shape in list)
Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));