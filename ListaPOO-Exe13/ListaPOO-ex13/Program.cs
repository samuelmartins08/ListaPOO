using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor do lado A:");
            double a = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado B:");
            double b = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado C:");
            double c = Double.Parse(Console.ReadLine());

            // Cria o objeto TrianguloRetangulo
            TrianguloRetangulo triangulo = new TrianguloRetangulo(a, b, c);

            // Verifica e exibe o resultado
            if (triangulo.FormaTriangulo())
            {
                if (triangulo.EhRetangulo())
                {
                    Console.WriteLine("Os valores formam um triângulo retângulo.");
                }
                else
                {
                    Console.WriteLine("Os valores formam um triângulo, mas NÃO é retângulo.");
                }
            }
            else
            {
                Console.WriteLine("Os valores NÃO formam um triângulo.");
            }
        }
    }
}
