using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06
{
    public class CarroCorrida
    {
        #region Atributos

        private int identificacao;
        private double velocidadeAtual;
        private double velocidadeMaxima;

        #endregion

        #region Propriedades
        public string VelocidadeAtual
        {
            get
            {
                return $"Velocidade do carro {identificacao} é de {velocidadeAtual}";
            }
            // get => $"Velocidade do carro {identificacao} é de {velocidadeAtual}";

        }

        public double VelocidadeMaxima
        {
            set
            {
                velocidadeMaxima = value;
            }
            // set => velocidadeMaxima = value;
        }

        public int Identicacao
        {
            set
            {
                identificacao = value;
            }
        }
        #endregion

        #region Propriedades auto implementadas

        public Motor Motor { get; set; }

        public Piloto Piloto { get; set; }

        // ou public Motor Motor

        #endregion


        #region Metodos
        public string Ligar()
        {
            return $"Carro {identificacao} ligado...";
        }

        public string Desligar()
        {
            return $"Carro {identificacao} desligado... ";
        }
        #endregion

        public void Acelerar()
        {
            velocidadeAtual += 10 + (Motor.Potencia * 0.1);

            if (Piloto.Habilidade > 0)
            {
                velocidadeAtual += Piloto.Habilidade * 0.5;
            }

            if (velocidadeAtual > velocidadeMaxima)
            {
                velocidadeAtual = velocidadeMaxima;
            }
        }

        public void Frear(int intensidadeFreada)
        {
            if (intensidadeFreada > 100)
            {
                intensidadeFreada = 100;
            }
            else if(intensidadeFreada < 0)
            {
                intensidadeFreada = 0;
            }

            velocidadeAtual -= intensidadeFreada * 0.25;

            if(velocidadeAtual < 0)
            {
                velocidadeAtual = 0;
            }
        }

    }
}
