using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio
{
    public class Carro
    {
        private string Marca;
        private string Modelo;
        private int VelocidadeAtual;

        public void DefinirMarca(string BMW)
        {
            Marca = BMW;
        }

        public void ObterMarca()
        {
            Console.WriteLine($"A marca do carro é {Marca}");
        }

        public void DefinirModelo(string Conversível)
        {
            Modelo = Conversível;
        }

        public void ObterModelo()
        {
            Console.WriteLine($"O modelo do seu carro é {Modelo}");
            Thread.Sleep(2500);
        }

        public void ObterVelocidade()
        {
            Console.WriteLine($"A velociddade atual está em {VelocidadeAtual} KM/H");
            
        }

        public void Acelerar(int Velocidade)
        {
            VelocidadeAtual += Velocidade;
            Console.WriteLine($"Velocidade atual em {VelocidadeAtual} KM/H");
            Thread.Sleep(2500);
            Console.Clear();
        }

        public void Frear(int Freio)
        {
            if (VelocidadeAtual <= 0)
            {
                Console.WriteLine($"O carro já está parado");
                return;
            }
            else
            {
                VelocidadeAtual -= Freio;
                Console.WriteLine($"Freiando com segurança...");
                Thread.Sleep(2000);
                Console.WriteLine($"Velocidade atual em {VelocidadeAtual} KM/H");
                Thread.Sleep(2000);
            }
        }
    }
}