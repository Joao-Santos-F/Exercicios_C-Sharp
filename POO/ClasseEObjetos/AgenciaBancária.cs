using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace ClasseEObjetos
{
    public class AgenciaBancária
    {
        public string Titular;
        public float Saldo;

        public void Sacar( float ValorSaque )
        {

            if (ValorSaque > Saldo)
            {
                Console.WriteLine($"Valor de saque maior que o saldo disponível");
                return;
            }
            else if (ValorSaque < 0)
            {
                Console.WriteLine($"O valor de saque tem que ser positivo");
                return;
            }
            else
            {
                Saldo -= ValorSaque;
            }

        }

        public void Deposito(float ValorDeposito)
        {
            if (ValorDeposito < 0)
            {
                Console.WriteLine($"Não é possível depositar valores negativos");
                return;
            }
            else
            {
                Saldo += ValorDeposito;
            }
            
        }
    }
}