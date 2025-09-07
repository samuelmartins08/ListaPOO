using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_Exe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrad = new Quadrado();
            Console.WriteLine("digite o valor do lado: ");
            quadrad.setAresta(int.Parse(Console.ReadLine()));
            quadrad.calcularArea();
            Console.WriteLine("A area do quadrado é:{0}", quadrad.getResult());
        }
    }
}
