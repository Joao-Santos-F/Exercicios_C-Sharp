using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEObjetos
{
    public class Garrafa
    {
        public string Cor;
        public int Capacidade;
        public int Tamando;
        public string Formato;
        public void abrir()
        {
            Console.WriteLine($"Thro");
        }
        public void beber()
        {
            Console.WriteLine($"Glub, Glub, Glub, Glub...");
        }
        public void acabou()
        {
            Console.WriteLine($"Delícia de água");
            
        }

    }
}