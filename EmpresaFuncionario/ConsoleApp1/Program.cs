/*Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.
Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.
Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.*/

using ConsoleApp1;
using System.Collections.Generic;
using System.Globalization;

/* Declarações de variaveis */
int N,id,funcionarioId;
string nome;
double salario,porcentagem;

/* Criação da Lista de funcionarios */
List<Funcionario> list = new List<Funcionario>();




Console.WriteLine("Quantos dados de funcionarios deseja ler?");
N= int.Parse(Console.ReadLine());   

for (int i = 0; i < N; i++)
{
    Console.WriteLine("Funcionario #" + i+1 + ":");
    Console.Write("Digite o Id do funcionario: ");
    id = int.Parse(Console.ReadLine());
    Console.Write("Digite o nome do funcionario:");
    nome = Console.ReadLine();
    Console.Write("Digite o Salario:");
    salario = double.Parse(Console.ReadLine());

    list.Add (new Funcionario(id,nome,salario));
}
/* recebendo o ID e valor da porcentagem que esta aumentando o salario do funcionario */
Console.Write("Entre com o Id do funcionario que deseja aumentar o salario:");
funcionarioId = int.Parse(Console.ReadLine());


Funcionario funcionario = list.Find(x => x.Id == funcionarioId);
if(funcionario != null)
{
    Console.Write("entre com a porcentagem que deseja aumentar? ");
    porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    funcionario.AumentoSalario(porcentagem);
}
else
    Console.WriteLine("O id digitado não existe");

Console.WriteLine();
Console.WriteLine("Update na lista dos funcionarios:");
foreach (Funcionario obj in list)
{
    Console.WriteLine(obj);
}
