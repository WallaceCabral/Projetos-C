using CotacacaoDolar;

Console.Write("Qual é a cotação atual do Dólar ?");
float valorDoDolar = float.Parse(Console.ReadLine());

Console.Write("Quantos dólares voce vai comprar? ");
float qtdeDolar = float.Parse(Console.ReadLine());

float result =ConversorDeMoeda.cotacao(valorDoDolar, qtdeDolar);

Console.WriteLine("Valor a ser pago em reais = "+result);
