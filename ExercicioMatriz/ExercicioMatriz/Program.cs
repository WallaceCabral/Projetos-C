/*Fazer um programa para ler um número inteiro N e uma matriz de
ordem N contendo números inteiros. Em seguida, mostrar a diagonal
principal e a quantidade de valores negativos da matriz.*/

using System;

Console.Write("Digite quantos valores serão lidos: ");
int n = int.Parse(Console.ReadLine());

int []  vet = new int[n];
int [,] mat = new int[n,n]; //criação da matriz na memoria 

Console.WriteLine("Digite a matriz separando cada linha por espaço: ex:1 2 3");
for (int i = 0; i < n; i++)
{
    
    string[] values = Console.ReadLine().Split(' ');// aqui esta recebendo o numero de forma de STRING;
    for (int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(values[j]); // aqui estamos convertendo o valor recebido pelo VALUES na posição J;
              
    }
}
Console.WriteLine("Diagonal principal: ");
for(int i = 0; i < n; i++)
{
    Console.WriteLine(mat[i,i]+ " "); // aqui ele pega a posição da diagonal
   
}
