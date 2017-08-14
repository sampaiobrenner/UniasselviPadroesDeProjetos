using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);

                if (i % 10 == 0)
                {
                    Console.WriteLine(String.Format("Número {0} é múltiplo de 10.", i));
                }
            }
            Console.ReadKey();
        }
    }
}
