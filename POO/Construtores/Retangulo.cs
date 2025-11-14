using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Retangulo
    {
        public float altura;
        public float largura;
        public float resultado;

        public Retangulo(float a, float l)
        {
            altura = a;
            largura = l;
        }

        public void ExibirDados()
        {
            resultado = altura * largura;
            Console.WriteLine($"A área total do retângulo deu {resultado}");
        }

        public Retangulo()
        {
            altura = 1;
            largura = 1;
        }
        
    }
}