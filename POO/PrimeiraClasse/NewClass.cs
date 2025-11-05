using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraClasse
{
    public class pessoa
    {
        public string nome;

        public int idade = 0;
        public float altura;

        public void Ola()
        {
            Console.WriteLine($"Eu sou {nome}, tenho {idade} anos e {altura} Metros");

        }

        public void despedir()
        {
            Console.WriteLine($"Irei domir agora porque já são 00:00, boa noite !");

        }

        public void dormindo()
        {
            Console.WriteLine($"zzzzzzzzzzzzzz...");
            Thread.Sleep(3000);
        }

        public void envelhecer(int _id = 0)
        {
            if (_id > 0)
            {
                idade += _id;
            }
            else
            {
                idade++;
            }
            
            Console.WriteLine($"Voce dormiu por 10 anos, agora tem {idade}");
            

        }
    }

}