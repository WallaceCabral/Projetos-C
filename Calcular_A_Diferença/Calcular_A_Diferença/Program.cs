using System;

int A, B, C, D, DIFERENCA;

Console.WriteLine("Digite os 4 valores para fazer o calculo da diferença");
A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
C = int.Parse(Console.ReadLine());
D = int.Parse(Console.ReadLine());

DIFERENCA = ((A * B) - (C * D));

Console.WriteLine("A diferença entre os numero foi : "+ DIFERENCA);