using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Retangulo : IForma
    {
        public float Largura;
        public float Altura;
        public float Resultado;
        public void CalcularArea()
        {
            Console.WriteLine($"Qual a largura do seu retangulo?");
            Largura = float.Parse(Console.ReadLine());

            Console.WriteLine($"Qual a altura do seu retangulo");
            Altura = float.Parse(Console.ReadLine());

            Resultado = Largura * Altura;

            Console.Clear();

            Console.WriteLine($"Pensando...");
            
            Thread.Sleep(2000);

            Console.Clear();

            Console.WriteLine($"A área do seu retangulo é de {Resultado}");
            
        }
    }
}