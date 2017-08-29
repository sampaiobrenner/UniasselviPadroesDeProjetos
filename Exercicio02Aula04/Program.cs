using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];
            int contadorPares = 0, contadorImpares = 0;

            // Captura de dados
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Informe o {i + 1} º valor: ");

                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Contagem de números pares
            foreach (var item in numeros)
            {
                if (item % 2 == 0)
                {
                    contadorPares++;
                }
            }
            Console.WriteLine("A quantidade de números pares é: " + contadorPares);

            // Mostra os números pares
            foreach (var item in numeros)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine($"O número {item} é par");
                }
            }

            // Contagem de números impares
            foreach (var item in numeros)
            {
                if (item % 2 != 0)
                {
                    contadorImpares++;
                }
            }
            Console.WriteLine("A quantidade de números impares é: " + contadorPares);

            // Mostra os números pares
            foreach (var item in numeros)
            {
                if (item % 2 != 0)
                {
                    Console.WriteLine($"O número {item} é impar");
                }
            }

            Console.ReadKey();


        }
    }
}
