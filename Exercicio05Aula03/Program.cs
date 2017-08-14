using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int maiorValor = 0;
            int menorValor = 0;
            int media;


            for (int i = 0; i < 15; i++)
            {
                do
                {
                    Console.WriteLine("Informe o " + (i + 1) + "º número (inteiro e positivo): ");
                    numero = int.Parse(Console.ReadLine());
                } while (numero <= 0);

                if (numero > 0)
                {
                    if (numero > maiorValor)
                    {
                        maiorValor = numero;
                    }

                    if (numero < menorValor)
                    {
                        menorValor = numero;
                    }
                }
            }

            media = maiorValor / menorValor;

            Console.WriteLine("Maior valor: " + maiorValor);

            Console.WriteLine("Menor valor: " + menorValor);

            Console.WriteLine("Média: " + media);

            Console.ReadKey();
        }
    }
}
