/*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.*/
using System;
using System.Globalization;

int num;


Console.Write("Digite quantas notas precisam ser lidas: ");
num =int.Parse(Console.ReadLine());

for(int i = 0; i < num; i++)
{
    string[] line = Console.ReadLine().Split(' ');
    double a = double.Parse(line[0]);
    double b = double.Parse(line[1]);
    double c = double.Parse(line[2]);

    double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;
    Console.WriteLine("Media: "+media.ToString("F1", CultureInfo.InvariantCulture));
    Console.WriteLine("");
}