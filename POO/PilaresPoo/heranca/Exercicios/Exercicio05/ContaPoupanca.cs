using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class ContaPoupanca : Conta
    {

        public float NovoRendimento;
        public void CalcularRendimento()
        {
            NovoRendimento = Saldo * 1.02f;

            Console.WriteLine($"O seu saldo hoje foi de {NovoRendimento}");
        }
    }
}