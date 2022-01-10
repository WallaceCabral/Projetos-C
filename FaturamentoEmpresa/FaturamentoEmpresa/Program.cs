using System;

class TestClass
{
    static void Main(string[] args)
    {

        Console.WriteLine("Programa Calculo de faturamento");


        int NumDias = 0, dias = 0; //dias será usado para informar o dia em que houve o menor e maior faturamento do mes 
        float MinValor = 0, MaxValor = 0;
        float faturamento = 0;


        Console.WriteLine("Digite quantos dias de faturamento deseja cadastrar: ");
        NumDias = int.Parse(Console.ReadLine());


        float[] vet = new float[NumDias]; // cria o vetor e o incia com numero de casas(NumDias) que o mesmo terá.
                                          // criado o vetor que vai armazenar os valores faturados de acordo com os dias digitados


        Console.WriteLine("Digite todos os valores faturados no mes");


        for (int i = 0; i < NumDias; i++)
        {
            float aux = float.Parse(Console.ReadLine()); // Variável aux pelo motivo de em C# nao poder atribuir diretamente ao vetor as entradas de dados
            vet[i] = aux; // Aqui ele recebe o valor do aux e joga para o velor

        }

        for (int i = 0; i < NumDias; i++)
        {
            faturamento = +vet[i];

            if (vet[i] >= MaxValor)
                MaxValor = vet[i];

            else
                MinValor = vet[i];
        }
        //aqui o programa pega a media do faturamento do mes.
        float MediaMes;
        MediaMes = faturamento / NumDias;
        int Dias = 0;

        for (int i = 0; i < NumDias; i++)
        {
            if (vet[i] > MediaMes)
            {
                Dias = +1;
            }
        }

        Console.WriteLine("esse é o Menor valor faturado R$ " + MinValor);
        Console.WriteLine("esse é o Maior valor faturado R$ " + MaxValor);
        Console.WriteLine("Numero de dias em que o faturamente foi a cima do valor diário " + Dias);
    }
}