using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosAula02
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = 0;
            double raio = 0;

            Console.Write("Informe o raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            area = (Math.PI * Math.Pow(raio, 2));

            // O método .ToString("n2") indica que o double írá imprimir somente com duas cadas decimais.
            Console.WriteLine(String.Format("A área do circulo é {0:2}", area));
            Console.ReadKey();
        }
    }
}
