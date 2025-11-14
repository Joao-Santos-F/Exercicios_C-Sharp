using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Gerente : Funcionario
    {
        public int Bonus = 1000;

        public int NovoSalario = 0;

        public void CalcularBonus()
        {
            NovoSalario = SalarioBase + Bonus;

            Console.WriteLine($"O seu novo salário será de R${NovoSalario}");
        }
    }
}