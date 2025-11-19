using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Circulo : IForma
    {
        public double Raio;
        public double Area;
        public void CalcularArea()
        {
            Console.WriteLine($"Qual o raio do seu círculo?");
            Raio = double.Parse(Console.ReadLine());
            
            Area = Math.PI * Raio * Raio;

            Console.Clear();

            Console.WriteLine($"Pensando...");
            
            Thread.Sleep(2000);

            Console.WriteLine($"O resultado da área do círculo deu {Area}");
            
        }
    }
}