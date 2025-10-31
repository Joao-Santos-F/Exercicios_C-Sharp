using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class pessoa
    {
        public string nome;

        public int idade;
        public float altura;

        public void Ola()
        {
            Console.WriteLine($"Eu sou {nome}, tenho {idade} e {altura} Metros");

        }

        public void tchau()
        {
            Console.WriteLine($"Irei domir agora porque já são 00:00, boa noite !");

        }

        public void dormindo()
        {
            Console.WriteLine($"zzzzzzzzzzzzzz...");
            Thread.Sleep(1500);
        }

        public void acordando()
        {
            Console.WriteLine($"Slk, que tu ainda tá fazendo aqui?");
            Console.WriteLine($"Fica me observando dormindo, tarado safado");
            
        }
    }

}