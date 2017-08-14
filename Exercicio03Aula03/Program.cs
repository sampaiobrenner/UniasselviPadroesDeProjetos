using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto;
            double quantidadeMedia = 0;

            Console.WriteLine("Informe a quantidade atual de estoque: ");
            double estoqueAtual = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade máxima de estoque: ");
            double estoqueMaximo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade mínima de estoque: ");
            double estoqueMinimo = Convert.ToDouble(Console.ReadLine());

            quantidadeMedia = (estoqueMaximo + estoqueMinimo) / 2;

            if (quantidadeMedia > estoqueAtual)
            {
                texto = "Efetuar compra!";
            } else
            {
                texto = "Não efetuar compra!";
            }

            Console.WriteLine(texto);
            Console.ReadKey();

        }
    }
}
