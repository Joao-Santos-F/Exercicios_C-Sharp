using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class ContaBancaria
    {
        public string titular;
        public float saldo;

        public ContaBancaria(string t, float s)
        {
            titular = t;
            saldo = s;
        }

        public ContaBancaria(string ti)
        {
            titular = ti;
            saldo = 0;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titular - {titular}");
            Console.WriteLine($"Saldo - {saldo}");
        }
    }
}