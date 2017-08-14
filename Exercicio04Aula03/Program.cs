using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = -1;
            int maiorNumero = 0;

            do
            {
                Console.WriteLine("Infome um numero: (Digite '0' para sair!)");
                numero = Convert.ToInt32(Console.ReadLine());

                if(numero > maiorNumero)
                {
                    maiorNumero = numero;
                }

            } while (numero != 0);

            Console.WriteLine("O maior número foi: " + maiorNumero);
            Console.ReadKey();
        }
    }
}
