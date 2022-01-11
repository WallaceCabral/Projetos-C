using System;


float pi = (float)3.14159;
float area,num1;

Console.WriteLine("Digite o valor do Raio: ");
num1 = float.Parse(Console.ReadLine());

area = pi * (num1*num1);

Console.WriteLine($"o valor da área deste círculo "+area.ToString("F4"));

