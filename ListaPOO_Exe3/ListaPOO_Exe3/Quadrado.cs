using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_Exe2
{
    internal class Quadrado
    {
        int diag;

        int result;

        public Quadrado()
        {
            this.diag = 0;
            this.result = 0;

        }

        public Quadrado(int aresta)
        {
            this.diag = aresta;

        }

        public void setAresta(int aresta)
        {
            this.diag = aresta;
        }

        public int getAresta()
        {
            return this.diag;
        }



        public int getResult()
        {
            return this.result;
        }



        public void calcularArea()
        {
            this.result = (this.diag * this.diag)/2;
        }
    }
}