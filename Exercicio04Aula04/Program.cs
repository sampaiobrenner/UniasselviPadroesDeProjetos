using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] produtos = new string[5];
            double[] precos = new double[5];
            int contador = 0;
            int index = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Infome o nome do produto: ");
                produtos[i] = Console.ReadLine();
                Console.Write("Informe o preço do produto: ");
                precos[i] = double.Parse(Console.ReadLine());
            }


            // Quantidade de itens com preco menor que 50
            foreach (var item in precos)
            {
                if (item < 50)
                {
                    contador++;
                }
            }
            Console.WriteLine("A quantidade de itens com preco menor que R$ 50,00 é: " + contador);

            // O nome dos itens com preço entre 50 e 100
            foreach (var item in precos)
            {
                if (item >= 50 &&  item <= 100)
                {
                    index = Array.IndexOf(precos, item);
                    Console.WriteLine($"O produto {produtos[index]} tem o preco entre R$ 50,00 e R$ 100,00. ");
                }  
            }

            Console.ReadKey();

        }
    }
}
