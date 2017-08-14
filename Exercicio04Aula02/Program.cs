using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo = 0;
            double velocidadeMedia = 0;
            double distanciaPercorrida = 0;
            double litrosConsumidos = 0;

            Console.WriteLine("Informe o tempo de viagem: ");
            tempo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a velocidade média: ");
            velocidadeMedia = Convert.ToDouble(Console.ReadLine());

            distanciaPercorrida = tempo * velocidadeMedia;

            litrosConsumidos = distanciaPercorrida / 12;

            Console.WriteLine(String.Format("Foram consumidos {0:0.00} litros", litrosConsumidos));
            Console.ReadKey();
        }
    }
}
