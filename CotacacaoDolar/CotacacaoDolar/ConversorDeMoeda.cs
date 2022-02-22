using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CotacacaoDolar
{
    internal class ConversorDeMoeda
    {
        public static float Iof = 6;

        public static float cotacao(float qtdeDolar,float valorDoDolar)
        {
            float total = qtdeDolar * valorDoDolar;
            return total + total * Iof / 100 ;
        }
    }
}
