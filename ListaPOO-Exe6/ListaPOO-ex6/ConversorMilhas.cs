using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex6
{
    internal class ConversorMilhas
    {
        private double milhas;
        private double km;
        public ConversorMilhas(double milhas)
        {
            this.milhas = milhas;
        }

        public void SetMilhas(double milhas)
        {
            this.milhas = milhas;
        }

        public double GetMilhas()
        {
            return this.milhas;
        }

        public double GetKm()
        {
            return this.km;
        }
        public void ConverterParaKm()
        {
            this.km = this.milhas * 1.852;
        }
    }
}
