using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            if (valor1 == valor2)
            {
                Console.WriteLine("Os valores devem ser distintos.");
                return;
            }
            Comparador comparador = new Comparador(valor1, valor2);
            comparador.DeterminarMaior();

            // Exibe o maior valor
            Console.WriteLine("O maior valor é:{0}", comparador.GetMaior());
        }
    }
}
