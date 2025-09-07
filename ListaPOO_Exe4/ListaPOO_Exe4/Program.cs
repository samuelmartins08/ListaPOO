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
            Triangulo triang = new Triangulo();
            Console.WriteLine("digite o valor da base: ");
            triang.setBase(int.Parse(Console.ReadLine()));
            Console.WriteLine("digite o valor da altura: ");
            triang.setAltura(int.Parse(Console.ReadLine()));
            triang.calcularArea();
            Console.WriteLine("A area do quadrado é:{0}", triang.getResult());
        }
    }
}