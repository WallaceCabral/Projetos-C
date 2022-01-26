/* Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/

int x, y;
Console.WriteLine("Digite dois valores inteiros: ");
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());  

while (x != 0 && y != 0)
{
    if (x >0 && y > 0)
    {
        Console.WriteLine("Primeiro Quadrante");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Quarto Quadrante");
    }
    else if(x < 0 && y < 0)
    {
        Console.WriteLine("Terceiro Quadrante");
    }
    else
    {
        Console.WriteLine("Segundo Quadrante");
    }
    Console.WriteLine("Digite dois valores inteiros: ");
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
}