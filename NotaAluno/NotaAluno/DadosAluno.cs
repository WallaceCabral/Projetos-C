using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaAluno
{
    internal class DadosAluno
    {
        public string Nome;
        public float Nota1, Nota2, Nota3;

        public float NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60)
            {
                return true;
            }
            else
                return false;
        }

        public float NotaRestante()
        {
            if (Aprovado())
            {
                return 0;
            }
            else
            {
                return 60 - NotaFinal() ;
            }

        }
    }
}
