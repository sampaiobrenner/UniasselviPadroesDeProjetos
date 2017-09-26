using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            CarroCorrida carro = new CarroCorrida();
            CarroCorrida carro2 = new CarroCorrida();

            Motor motor = new Motor();
            Motor motor2 = new Motor();
            motor.Potencia = 320;
            motor2.Potencia = 280;

            carro.Motor = motor;

            carro.Identicacao = 1010;
            carro.VelocidadeMaxima = 140;

            Piloto piloto = new Piloto();
            carro.Piloto = piloto;

            Console.WriteLine(carro.Ligar());
            Console.WriteLine(carro.VelocidadeAtual);
            carro.Acelerar();
            Console.WriteLine(carro.VelocidadeAtual);
            carro.Acelerar();
            Console.WriteLine(carro.VelocidadeAtual);
            carro.Acelerar();
            Console.WriteLine(carro.VelocidadeAtual);
            carro.Acelerar();
            Console.WriteLine(carro.VelocidadeAtual);
            Console.WriteLine(carro.Desligar());
            Console.WriteLine(carro.VelocidadeAtual);
            Console.ReadLine();
        }
    }
}
