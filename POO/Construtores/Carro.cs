using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Construtores
{
    public class Carro
    {
        public string marca;
        public string modelo;
        public int ano;

        public Carro(string mar, string mod, int a)
        {
            marca = mar;
            modelo = mod;
            ano = a;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano: {ano}");
        }

    }
}