using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo = 50000;

        public override double Depositar(double ValorDeposito)
        {
            Console.WriteLine($"Quanto você deseja depositar?");
            ValorDeposito = double.Parse(Console.ReadLine());

            if (ValorDeposito < 0)
            {
                Console.WriteLine($"O seu valor de depósito não pode ser negativo ou nulo");
                return -1;
            }
            else
            {
                double y = Saldo += ValorDeposito * 1.05;
                Console.WriteLine($"O seu novo saldo é de R${y}");
                return y;
            }

        }

        public override double Sacar(double ValorSaque)
        {
            Console.WriteLine($"Quanto você deseja sacar ?");
            ValorSaque = double.Parse(Console.ReadLine());

            if (ValorSaque > Saldo)
            {
                Console.WriteLine($"O seu valor de saque está maior que o seu saldo no momento de R${Saldo}");
                return -1;
            }
            else
            {
                double x = Saldo -= ValorSaque;
                Console.WriteLine($"O seu novo saldo é de R${x}");
                return x;
            }
            
        }
    }
}