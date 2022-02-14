/*Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.*/
using PessoaMaisVelha;

Dados nome, idade;


Dados p1 = new Dados();
Dados p2 = new Dados();



Console.WriteLine("Digite o nome da 1° pessoa:");
p1.nome = Console.ReadLine();

Console.WriteLine("Digite a idade da 1° pessoa:");
p1.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o nome da 2° pessoa:");
p2.nome = Console.ReadLine();

Console.WriteLine("Digite a idade da 2° pessoa:");
p2.idade = int.Parse(Console.ReadLine());


if(p1.idade > p2.idade)
{
    Console.WriteLine("O mais velho é: " + p1.nome);
}
else
{
    Console.WriteLine("O mais velho é: " + p2.nome);
}