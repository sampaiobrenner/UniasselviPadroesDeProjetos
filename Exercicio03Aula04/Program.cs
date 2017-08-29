using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            int posicao = 0;
            string nome = "";
            int index = 0;

            for (int i = 0; i < nomes.Length; i++)
            {
                Console.Write($"Informe o {i + 1} º nome: ");

                nomes[i] = Console.ReadLine();
            }

            Console.Write($"Informe uma posição: ");
            posicao = int.Parse(Console.ReadLine()) - 1;

            if (posicao >= 0 || posicao < 10)
            {
                Console.WriteLine($"O nome informado na posição {posicao + 1} é: {nomes[posicao]}");
            }
            else
            {
                Console.WriteLine("A posição informada é inválida!");
            }

            Console.WriteLine("Informe um nome: ");
            nome = Console.ReadLine();

            index = Array.IndexOf(nomes, nome);

            Console.WriteLine($"A posição de '{nome}' é: {index + 1}");
            
            Console.ReadKey();

        }
    }
}
