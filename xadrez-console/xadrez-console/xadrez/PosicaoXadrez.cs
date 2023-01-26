using System;
using tabuleiro;

namespace xadrez
{
     class PosicaoXadrez
    {
        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao() {
            return new Posicao('a' - coluna, 8 - linha);
 }
        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
