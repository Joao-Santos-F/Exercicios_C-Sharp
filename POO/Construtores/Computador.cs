using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Computador
    {
        public string marca;
        public float memoriaRam;
        public float armazenamento;

        public Computador()
        {
            marca = "Linux";
            memoriaRam = 16;
            armazenamento = 512;
        }

        public Computador(string m, float me, float a)
        {
            marca = m;
            memoriaRam = me;
            armazenamento = a;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"O seu computador da marca {marca}, Memoria ram de {memoriaRam} GB e armazenamento de {armazenamento} GB");
            Console.WriteLine($"Está na mão do torolho, eu teria medo");
        }

    }
}