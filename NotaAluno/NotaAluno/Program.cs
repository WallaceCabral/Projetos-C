using NotaAluno;
using System.Globalization;

DadosAluno Aluno;
Aluno = new DadosAluno();


Console.Write("Qual o nome do aluno? ");
Aluno.Nome = Console.ReadLine();

Console.WriteLine();
Console.Write("Digite as notas: ");
Aluno.Nota1 = float.Parse(Console.ReadLine());
Aluno.Nota2 = float.Parse(Console.ReadLine());
Aluno.Nota3 = float.Parse(Console.ReadLine());


Console.WriteLine("Nota Final = "+Aluno.NotaFinal().ToString("F2",CultureInfo.InvariantCulture));

if (Aluno.Aprovado())
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
    Console.WriteLine("Faltaram: "+Aluno.NotaRestante()+" pontos");
}


