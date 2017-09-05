using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = -1;
            string [] nomes = new string [10];

            nomes[0] = "Matheus Sampaio";
            nomes[1] = "Daniele Sampaio";
            nomes[2] = "Cristina Sampaio";
            nomes[3] = "Marina Nunes";
            nomes[4] = "Paulo Sampaio";
            nomes[5] = "Rossana Sampaio";
            nomes[6] = "Roberta Sampaio";
            nomes[7] = "Nathalia Bandeira";
            nomes[8] = "Getúlio Franco";
            nomes[9] = "Flávio Brenner";

            do
            {
                Console.WriteLine();
                Console.WriteLine("============== Menu ==============");
                Console.WriteLine("1) Pesquisar Nome");
                Console.WriteLine("2) Listar Todos Os Nomes");
                Console.WriteLine("0) Sair do Programa");
                Console.WriteLine("==================================");
                Console.WriteLine();
                try
                {
                    Console.Write("Opção: ");
                    opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    switch (opcao)
                    {
                        case 1:

                            Console.Write("Digite um nome: ");
                            Console.WriteLine();
                            string teclado = Console.ReadLine();

                            for (int i = 0; i < nomes.Length; i++)
                            {
                                if (nomes[i].LastIndexOf(teclado, StringComparison.OrdinalIgnoreCase) > 0)
                                {
                                    Console.WriteLine("Nome encontrado: " + nomes[i]);
                                }
                            }

                            break;

                        case 2:

                            for (int i = 0; i < nomes.Length; i++)
                            {
                                Console.WriteLine("Nome encontrado: " + nomes[i]);
                            }

                            break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine();
                    Console.WriteLine("                        Atenção! Ocorreu um erro:                         ");
                    Console.WriteLine("\n * " + ex.Message);
                    Console.WriteLine();
                    Console.WriteLine("==========================================================================");
                    Console.WriteLine();
                }


            } while (opcao != 0);
           
        }
    }
}
