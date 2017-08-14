using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            double media = 0;

            Console.Write("Informe a nota parcial 1: ");
            double primeiraParcial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota oficial 1: ");
            double primeiraOficial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota parcial 2: ");
            double segundaParcial = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe a nota oficial 2: ");
            double segundaOficial = Convert.ToDouble(Console.ReadLine());

            media = (primeiraParcial * 1.2) + (primeiraOficial * 2.8) + (segundaParcial * 1.8) + (segundaOficial * 4.2);
            media /= 10;

            Console.Write(String.Format("A média é: {0:00}", media));
            Console.ReadKey();
        }
    }
}
