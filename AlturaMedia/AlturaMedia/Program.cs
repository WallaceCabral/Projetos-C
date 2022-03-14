/*Fazer um programa para ler um número inteiro N e a altura de N pessoas.
Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas
pessoas.*/

using System.Globalization;

double aux = 0,media;

Console.WriteLine("Digite quantas alturas deseja ler: ");
int n = int.Parse(Console.ReadLine());

double[] vect = new double[n]; // criando um vetor de 'N' posições;

Console.WriteLine("Digite as alturas:");
for (int i = 0; i < n; i++)
{
    vect [i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); 
    aux =aux + vect [i];
}

media = aux / n;

Console.WriteLine("A media das Alturas é: " +media.ToString("F2", CultureInfo.InvariantCulture));

