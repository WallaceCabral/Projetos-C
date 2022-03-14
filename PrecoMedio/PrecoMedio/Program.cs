/*Fazer um programa para ler um número inteiro N e os dados (nome e
preço) de N Produtos. Armazene os N produtos em um vetor. Em
seguida, mostrar o preço médio dos produtos.*/

using PrecoMedio;
using System.Globalization;

int n;
double soma = 0,media;


Console.WriteLine("Digite a quantidade de produtos para leitura");
n = int.Parse(Console.ReadLine());

Produto[] vect = new Produto[n];

Console.WriteLine("Digite Nome e depois o Preço dos produtos");
for (int i = 0; i < n; i++)
{
    string nome = Console.ReadLine();
    double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Produto { Nome = nome, Preco = preco };
}

for (int i = 0; i < n; i++)
{
    soma += vect[i].Preco;
}

media = soma / n;

Console.WriteLine("A media de valores entre "+n+ "produtos é: "+media.ToString("F2",CultureInfo.InvariantCulture));
