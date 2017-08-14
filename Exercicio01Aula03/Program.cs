using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01Aula03
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "";

            Console.WriteLine("Informe o primeiro número: ");
            double primeiroNumero = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número:");
            double segundoNumero = Convert.ToDouble(Console.ReadLine());

            if (primeiroNumero == segundoNumero)
            {
                texto = "Números iguais!";
            } else if (primeiroNumero > segundoNumero)
            {
                texto = "Primeíro é maior!";
            } else if (segundoNumero > primeiroNumero)
            {
                texto = "Segundo é maior!";
            }

            Console.WriteLine(texto);
            Console.ReadKey();
        }
    }
}
