using System;

string nomeCompleto,nome;
int quartos,idade;
double preço,altura;


Console.WriteLine("Entre com seu nome completo:");
nomeCompleto = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa ?");
quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto:");
preço = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com seu nome, idade e altura (mesma linha)");
string[] vet = Console.ReadLine().Split(' ');
nome = vet[0];
idade = int.Parse(vet[1]);
altura = double.Parse(vet[2]);


Console.WriteLine(nomeCompleto);
Console.WriteLine(quartos);
Console.WriteLine(preço);
Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(altura);



