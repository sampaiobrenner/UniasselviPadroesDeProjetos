using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01Aula02
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

            Console.WriteLine(String.Format("A área do circulo é {0:0.00}", area));
            Console.ReadKey();
        }
    }
}
