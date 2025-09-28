using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex8
{
    internal class Comparador
    {
        private double valor1;
        private double valor2;
        private double maior;
        public Comparador(double valor1, double valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
        }
        public double GetValor1()
        {
            return this.valor1;
        }

        public double GetValor2()
        {
            return this.valor2;
        }

        public double GetMaior()
        {
            return this.maior;
        }
        public void DeterminarMaior()
        {
            if (this.valor1 > this.valor2)
            {
                this.maior = this.valor1;
            }
            else
            {
                this.maior = this.valor2;
            }
        }
    }
}
