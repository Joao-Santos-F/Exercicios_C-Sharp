using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class PessoaC
    {
        public string nome;
        public int idade;

        public PessoaC()
        {
            
        }

        public PessoaC(string n)
        {
            nome = n;
        }

        public PessoaC(string n, int i)
        {
            nome = n;
            idade = i;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Bem-Vindo {nome}, você tem {idade} anos");
        }

    }
}