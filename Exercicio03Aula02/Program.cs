using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            int auxiliar = 0;

            Console.Write(" Informe o número inteiro A: ");
            int inteiroA = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Informe o número inteiro B: ");
            int inteiroB = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(String.Format("\n VALORES ANTES DA ALTERAÇÃO: \n\n Inteiro A: {0} | Inteiro B: {1}", inteiroA, inteiroB));

            auxiliar = inteiroA;
            inteiroA = inteiroB;
            inteiroB = auxiliar;

            Console.WriteLine(String.Format("\n VALORES DEPOIS DA ALTERAÇÃO: \n\n Inteiro A: {0} | Inteiro B: {1}", inteiroA, inteiroB));

            Console.ReadKey();
        }
    }
}
