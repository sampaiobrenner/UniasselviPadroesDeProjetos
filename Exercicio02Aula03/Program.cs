using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            double precoCusto = 0;
            double custoTotal = 0;

            Console.WriteLine("Infome o número de maças compradas. ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 12)
            {
                precoCusto = 1;
            } else
            {
                precoCusto = 1.3;
            }
            custoTotal = precoCusto * numero;

            Console.WriteLine($"O custo total foi: {custoTotal:0.00}");
            Console.ReadKey();
        } 
    }
}
