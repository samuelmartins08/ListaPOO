using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_Exe2
{
    internal class Quadrado
    {
        int aresta;
       
        int result;

        public Quadrado()
        {
            this.aresta = 0;
            this.result = 0;
            
        }

        public Quadrado(int aresta)
        {
            this.aresta = aresta;
            
        }

        public void setAresta(int aresta)
        {
            this.aresta = aresta;
        }

        public int getAresta()
        {
            return this.aresta;
        }



        public int getResult()
        {
            return this.result;
        }

      

        public void calcularArea()
        {
            this.result = this.aresta * 2;
        }
    }
}
