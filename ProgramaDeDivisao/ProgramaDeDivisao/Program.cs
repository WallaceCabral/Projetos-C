using System;
using System.Globalization;

Console.WriteLine("Digite quantos vezes deseja usar o programa ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Digite os valores primeiro o numerador e seguido do denominador ");

    string[] line = Console.ReadLine().Split(' ');
    int x = int.Parse(line[0]);
    int y = int.Parse(line[1]);

    if (y == 0)
    {
        Console.WriteLine("divisao impossivel");
    }
    else
    {
        double div = (double)x / y;
        Console.WriteLine("O resultado é: "+div.ToString("F1", CultureInfo.InvariantCulture));
    }
}
