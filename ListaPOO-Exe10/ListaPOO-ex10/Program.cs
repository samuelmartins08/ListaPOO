using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor da base do terreno:");
            double baseRet = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor da altura do terreno:");
            double alturaRet = Convert.ToDouble(Console.ReadLine());

            Terreno terreno = new Terreno(baseRet, alturaRet);
            terreno.CalcularArea();

            Console.WriteLine("Área do terreno: {0} m²", terreno.GetArea());

            if (terreno.GetArea() > 100)
            {
                Console.WriteLine("Terreno grande");
            }
            else
            {
                Console.WriteLine("Terreno pequeno");
            }
        }
    }
}
