using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Pessoa : Animal
    {
        public string nome = "Rarael";

        public int idade = 67;

        public override void FazerSom()
        {
            Console.WriteLine($"Six Seven");
            
        }

        public override void Mover()
        {
            Console.WriteLine($"Tralalero Tralala");
            
        }

        public void Dormir()
        {
            Console.WriteLine($"zzzzzzz");
            Console.WriteLine($"O {nome} está dormindo, ele tem {idade} anos e ama tiktok");
            
        }
    }
}