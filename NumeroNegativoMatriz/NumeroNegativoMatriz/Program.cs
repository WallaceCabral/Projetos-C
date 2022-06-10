
Console.WriteLine("Digite o tamanho da matriz N X N ");
int n = int.Parse(Console.ReadLine());

int[,] mat = new int[n,n];
int[] numeroNegativo = new int[n];

for (int i = 0; i<n; i++)
{
    string [] values = Console.ReadLine().Split(' ');// Split :responsavel por pegar a linha inteira do vetor . ex: 123 

    for(int j = 0; j < n; j++)
    {
        mat[i,j] = int.Parse(values[j]);

        if (mat[i,j] <= -1) //if para pegar o numero negativo e guardar no vetor;
        {
            numeroNegativo[i] = mat[i,j];
        }
    }
}
for(int i = 0; i < n; i++)
{
    if(numeroNegativo[i]<0) //if para imprimir o numero negativo que esta no vetor ;
    Console.WriteLine(numeroNegativo [i]);
}
