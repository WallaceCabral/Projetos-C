Console.WriteLine("Condicional Ternária");

Console.WriteLine("Qual o valor do preço ?");
double preco = double.Parse(Console.ReadLine());


double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

Console.WriteLine(desconto);

