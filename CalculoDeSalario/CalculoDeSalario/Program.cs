using System;

int num,horas;
float valorHora,salario;

Console.WriteLine("Digite seu numero de funcionario");
num =int.Parse(Console.ReadLine());

Console.WriteLine("Digite quantas horas foram trabalhadas");
horas = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor da hora trabalhada");
valorHora = float.Parse(Console.ReadLine());

salario = (float)horas * valorHora;

Console.WriteLine($"Numero: {num}, seu salario foi de R${salario.ToString("F2")}");