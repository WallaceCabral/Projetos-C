﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    internal class Formula
    {
        public double largura,altura;

        public double Area()
        {
            return largura * altura; 
        }

        public double Perimetro()
        {
            return 2*(largura + altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);
        }
    }
}
