using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex9
{
    internal class Comparador
    {

        private double valor1;
        private double valor2;
        public Comparador(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }

        public bool SaoIguais()
        {
            return this.valor1 == this.valor2;
        }

        public double DeterminarMaior()
        {
            return (this.valor1 > this.valor2) ? this.valor1 : this.valor2;
        }
    }
}
