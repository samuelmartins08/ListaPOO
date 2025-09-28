using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quantidade de milhas marítimas:");
            double milhas = Convert.ToDouble(Console.ReadLine());

            ConversorMilhas conversor = new ConversorMilhas(milhas);
            conversor.ConverterParaKm(); 
            Console.WriteLine("O valor de {0} milhas marítimas em quilômetros é:{1:F3} Km", milhas, conversor.GetKm());
        }
    }
}
