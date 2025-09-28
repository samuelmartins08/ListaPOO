using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex11
{
    internal class Pessoa
    {
        private double peso;
        private double altura;
        private double relacao;

        public Pessoa(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double GetPeso() => this.peso;
        public double GetAltura() => this.altura;
        public double GetRelacao() => this.relacao;

        public void CalcularRelacao()
        {
            this.relacao = this.peso / (this.altura * this.altura);
        }

        public string ClassificarPeso()
        {
            if (relacao < 20)
            {
                return "Abaixo do peso";
            }
            else if (relacao >= 20 && relacao < 25)
            {
                return "Peso ideal";
            }
            else
            {
                return "Acima do peso";
            }
        }

    }
}
