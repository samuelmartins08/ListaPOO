using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPOO_ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o peso da pessoa (em kg):");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a altura da pessoa (em metros):");
            double altura = Convert.ToDouble(Console.ReadLine());

            Pessoa pessoa = new Pessoa(peso, altura);
            pessoa.CalcularRelacao();

            Console.WriteLine($"Relação peso/altura² (R): {pessoa.GetRelacao():F2}");
            Console.WriteLine($"Classificação: {pessoa.ClassificarPeso()}");
        }
    }
}
