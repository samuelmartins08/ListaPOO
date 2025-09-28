using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação atual do dólar:");
            double cotacao = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor em dólares:");
            double quantidade = Convert.ToDouble(Console.ReadLine());
            ConversorDolar conversor = new ConversorDolar(cotacao, quantidade);
            conversor.CalcularReais();
            Console.WriteLine("O valor em reais é: R$ {0:F2}", conversor.GetValorReais());
        }
    }
}
