

Console.WriteLine("Vamos criar o Fibonacci");


int num1 = 0, num2 = 1, aux,numDigitado;
int fibonacci=0;

Console.WriteLine("Qual numero deseja verificar se faz parte do fibonacci ?");

numDigitado = int.Parse(Console.ReadLine());

for(int i = 0; i <= numDigitado; i++)
{
    aux = num1; 
    num1 = num2; 
    num2 = num1 + aux; 

    if (num2 == numDigitado)
    {
        fibonacci = numDigitado;  
    }
}

if (fibonacci == numDigitado)
{
    Console.WriteLine("O numero digitado faz parte de fibonacci");
}
else
    Console.WriteLine("O numero digitado NÃO faz parte de fibonacci");


