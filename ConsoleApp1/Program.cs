using System;

namespace MediaEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            float SP = (float)67836.43,
            RJ = (float)36678.66,
            MG = (float)29229.88,
            ES = (float)27165.48,
            OUTROS = (float)19849.53,
            Total = (SP + RJ + MG + ES + OUTROS);



            double P_SP = ((SP / Total) * 100);
            double P_RJ = ((RJ / Total) * 100);
            double P_MG = ((MG / Total) * 100);
            double P_ES = ((ES / Total) * 100);
            double P_OUT = ((OUTROS / Total) * 100);



            Console.WriteLine($"o percentual de representação {P_SP.ToString("F2")}%");
            Console.WriteLine($"o percentual de representação {P_RJ.ToString("F2")}%");
            Console.WriteLine($"o percentual de representação {P_MG.ToString("F2")}%");
            Console.WriteLine($"o percentual de representação {P_ES.ToString("F2")}%");
            Console.WriteLine($"o percentual de representação {P_OUT.ToString("F2")}%");

        }
    }
}