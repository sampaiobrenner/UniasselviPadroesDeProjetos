using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06Aula04
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[10, 5];
            Random numero = new Random();
            int menor;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = numero.Next(10, 99);
                }
            }

            menor = matriz[0, 0];

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matriz[i, j] < menor)
                    {
                        menor = matriz[i, j];
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i, j] + "\t"); 
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("O menor é: " + menor);

            Console.ReadKey();
        }
    }
}
