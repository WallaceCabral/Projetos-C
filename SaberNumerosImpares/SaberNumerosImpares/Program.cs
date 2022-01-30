/*Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.*/

int num;

Console.WriteLine("Digite um valor");
num =int.Parse(Console.ReadLine());

for (int i = 0; i <= num; i++)
{
    if (i % 2 != 0)
    {
        Console.WriteLine(i);
    }

}