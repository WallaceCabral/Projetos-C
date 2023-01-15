
using System.Collections.Concurrent;

try
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());

    int result = n1 / n2;

    Console.WriteLine(result);
}
catch (DivideByZeroException )
{
    Console.WriteLine("não é permitido divisão por zero");    
}
catch (FormatException)
{
    Console.WriteLine("não é permitido a entrada de caracteres");
}
