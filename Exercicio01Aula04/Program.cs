using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.Write($"Informe o {i + 1} valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 19; i >= 0; i--)
            {
                Console.Write($"{numeros[i]} ");
            }

            //Array.Sort(numeros);

            Console.ReadKey();
        }
    }
}
