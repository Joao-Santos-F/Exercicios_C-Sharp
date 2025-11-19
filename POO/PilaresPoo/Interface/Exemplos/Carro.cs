using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Carro : IMotor
    {

        public string Cor;
        public string Marca;
        public string Modelo;
        public int Ano;

        public Carro(string c, string m, string md, int a)
        {
            Cor = c;
            Marca = m;
            Modelo = md;
            Ano = a;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Informações do Carro");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cor: {Cor}");
        }

        public void Acelerar()
        {
            Console.WriteLine($"Vrum vrum vrum");
            
        }

        public void Frear()
        {
            Console.WriteLine($"skiiiiiiiiiiiiiiiiiiiiiiiirrrrrrrr… PSSHHH!");
            
        }
    }
}