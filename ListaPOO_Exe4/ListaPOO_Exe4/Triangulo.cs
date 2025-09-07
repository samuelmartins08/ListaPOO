using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_Exe4
{
    internal class Triangulo
    {
        int b;
        int a;
        int result;

        public Triangulo()
        {
            this.b = 0;
            this.a = 0;
            this.result = 0;

        }

        public Triangulo(int b)
        {
            this.b = b;

        }

        public void setBase(int b)
        {
            this.b = b;
        }

        public int getBase()
        {
            return this.b;
        }
        
        public void setAltura(int a)
        {
            this.a = a;
        }
        
        public int getAltura(int a)
        {
            return this.a;
        }

        public int getResult()
        {
            return this.result;
        }



        public void calcularArea()
        {
            this.result = this.b * this.a /2;
        }
    }
}