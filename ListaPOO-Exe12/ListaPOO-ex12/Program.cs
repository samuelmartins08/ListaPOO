using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado A:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C:");
            double c = Convert.ToDouble(Console.ReadLine());

            Triangulo triangulo = new Triangulo(a, b, c);

            if (triangulo.FormaTriangulo())
            {
                Console.WriteLine("Os lados formam um triângulo.");
                Console.WriteLine("Classificação:{0}", triangulo.Classificar());
            }
            else
            {
                Console.WriteLine("Os valores informados NÃO formam um triângulo.");
            }
        }
    }
}
