/*Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.*/

int alcool, gasolina, diesel,fim;
int al=0, gas=0, die=0;

Console.WriteLine("Qual combustivel deseja abastecer ?");
Console.WriteLine("1 - Alcool");
Console.WriteLine("2 - Gasolina");
Console.WriteLine("3 - Diesel");
Console.WriteLine("4 - FIM");

fim = int.Parse(Console.ReadLine());

while (fim != 4)
{
    if(fim == 1)
    {
        al++;
    }
    else if (fim == 2)
    {
        gas++;
    }
    else if(fim == 3)
    {
        die++;
     }

    Console.WriteLine("Abastecimentos até o momento");

    Console.WriteLine("Alcool:" + al);
    Console.WriteLine("Gasolina:" + gas);
    Console.WriteLine("Diesel:" + die);

    Console.WriteLine("-------------------------------------");
    Console.WriteLine("Qual combustivel deseja abastecer ?");
    Console.WriteLine("1 - Alcool");
    Console.WriteLine("2 - Gasolina");
    Console.WriteLine("3 - Diesel");
    Console.WriteLine("4 - FIM");

    Console.WriteLine("-------------------------------------");

    fim = int.Parse(Console.ReadLine());

}
Console.WriteLine("Muito Obrigado");