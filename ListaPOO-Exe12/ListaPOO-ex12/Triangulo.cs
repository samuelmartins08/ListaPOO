using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex12
{
    internal class Triangulo
    {
        private double a;
        private double b;
        private double c;

        public Triangulo(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public bool FormaTriangulo()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public string Classificar()
        {
            if (a == b && b == c)
            {
                return "Equilátero";
            }
            else if (a == b || a == c || b == c)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }
}
