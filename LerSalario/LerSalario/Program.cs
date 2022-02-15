/*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.*/
using LerSalario;


Empresa p1, p2;
p1 = new Empresa();
p2 = new Empresa();


Console.WriteLine("Digite o NOME do 1° funcionario:");
p1.nome = Console.ReadLine();
Console.WriteLine("Digite o SALARIO do 1° funcionario:");
p1.salario = double.Parse(Console.ReadLine());



Console.WriteLine("Digite o NOME do 2° funcionario:");
p2.nome = Console.ReadLine();
Console.WriteLine("Digite o SALARIO do 2° funcionario:");
p2.salario = double.Parse(Console.ReadLine());

double media = (p1.salario + p2.salario)/ 2;

Console.WriteLine("Salario medio é de R$ "+media);
