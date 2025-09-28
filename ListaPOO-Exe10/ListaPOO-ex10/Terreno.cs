using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex10
{
    internal class Terreno
    {
        private double baseRet;
        private double altura;
        private double area;

        public Terreno(double baseRet, double altura)
        {
            this.baseRet = baseRet;
            this.altura = altura;
        }

        public double GetBase()
        {
            return this.baseRet;
        }

        public double GetAltura()
        {
            return this.altura;
        }

        public double GetArea()
        {
            return this.area;
        }

        public void CalcularArea()
        {
            this.area = this.baseRet * this.altura;
        }
    }
}
