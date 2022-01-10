using System.Linq;
using static System.Console;
namespace InversaoDeTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto a ser invertido:");
            string texto = Console.ReadLine();

            Console.WriteLine($"Texto Normal   : {texto}");

            string textoInvertido = new string(texto.Reverse().ToArray()); //aqui faz com que o texto fique ao contrario.
            Console.WriteLine($"Texto Invertido: {textoInvertido}");

        }
    }
}