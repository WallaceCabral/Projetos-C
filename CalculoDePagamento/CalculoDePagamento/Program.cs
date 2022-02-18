using CalculoDePagamento;

Funcionario F;

F = new Funcionario();
float porcent; 

Console.WriteLine("Entre com os dados do funcionario");
Console.Write("Nome: ");
F.Nome = Console.ReadLine();

Console.WriteLine();
Console.Write("Salario Bruto: ");
F.SalarioBruto = float.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Imposto: ");
F.Imposto = float.Parse(Console.ReadLine());

Console.WriteLine();
Console.Write("Digite a porcentagem de aumento: ");
porcent = float.Parse(Console.ReadLine());

F.AumentorSalario(porcent);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + F);

