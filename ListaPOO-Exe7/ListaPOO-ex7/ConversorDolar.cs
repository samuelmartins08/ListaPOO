using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex7
{
    internal class ConversorDolar
    {
        private double cotacaoDolar;
        private double quantidadeDolares;
        private double valorReais;

        public ConversorDolar(double cotacaoDolar, double quantidadeDolares)
        {
            this.cotacaoDolar = cotacaoDolar;
            this.quantidadeDolares = quantidadeDolares;
        }

        public void SetCotacaoDolar(double cotacao)
        {
            this.cotacaoDolar = cotacao;
        }

        public void SetQuantidadeDolares(double quantidade)
        {
            this.quantidadeDolares = quantidade;
        }

        public double GetCotacaoDolar()
        {
            return this.cotacaoDolar;
        }

        public double GetQuantidadeDolares()
        {
            return this.quantidadeDolares;
        }

        public double GetValorReais()
        {
            return this.valorReais;
        }
        public void CalcularReais()
        {
            this.valorReais = this.quantidadeDolares * this.cotacaoDolar;
        }
    }
}

