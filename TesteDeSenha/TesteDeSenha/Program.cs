using System;

int senha = 123456, contador =0,check=0;
string login;

Console.WriteLine("Entre com seu login");
login = Console.ReadLine();


while (senha != 123456 || contador != 3)
{
    Console.WriteLine("Digite sua senha:");
    check = int.Parse(Console.ReadLine()); 

    contador++;
}
if (check == senha)
{
    Console.WriteLine("Logado com Sucesso");
}
else
    Console.WriteLine("Usuário bloqueado por tentativa de senha incorretas");