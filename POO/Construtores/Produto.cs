using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Produto
    {
        public string nome;
        public float preco;
        public int estoque;

        public Produto(string n, float p, int e)
        {
            nome = n;
            preco = p;
            estoque = e;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome do produto - {nome}");
            Console.WriteLine($"Preço do produto - {preco}");
            Console.WriteLine($"Quantidade em estoque - {estoque}");
        }
    }
}