using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ControleRemoto : IControle
    {
        public int Volume = 30;
        public int VolumeMaximo = 30;

        public void Ligar()
        {
            Console.WriteLine($"Ligando a TV...");
            
        }

        public void Desligar()
        {
            Console.WriteLine($"Desligando a TV...");
            
        }

        public void AumentarVolume()
        {
            if (Volume == VolumeMaximo)
            {
                Console.WriteLine($"A TV já está no volume máximo");
                return;
            }
            Volume++;
            Console.WriteLine($"Volume: {Volume}");
            
        }

        public void DiminuirVolume()
        {
            if (Volume == 0)
            {
                Console.WriteLine($"A TV já está com o volume nulo");
                return;
            }
            Volume--;
            Console.WriteLine($"Volume: {Volume}");
            
        }

    }
}