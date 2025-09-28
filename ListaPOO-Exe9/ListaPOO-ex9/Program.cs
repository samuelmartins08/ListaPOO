using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Comparador comparador = new Comparador(valor1, valor2);

            if (comparador.SaoIguais())
            {
                Console.WriteLine("Os números são iguais, tonho.");
            }
            else
            {
                Console.WriteLine("O maior valor é:{0}", comparador.DeterminarMaior());
            }
        }
    }
}
