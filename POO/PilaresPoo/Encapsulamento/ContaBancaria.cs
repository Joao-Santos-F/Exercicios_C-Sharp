using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

        public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
            if (SaldoInicial > 0)
            {
                Saldo = SaldoInicial;
            }
            else
            {
                Saldo = 0;
            }
        }

        //Métodos Gets and Sets


        
        //set do Saldo
        public void Depositar(float valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine($"Não é permitifo depositar valores nulos ou negativos");
            }
            else
            {
                Saldo -= valor;
            }

        }

         public void Sacar(float valor)
        {
            if (valor >= 0 && valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine($"So é permitido sacar valores acima de R$0");
            }
        }

        public float GetSaldo()
        {
            return Saldo;
        }

       
    }
}