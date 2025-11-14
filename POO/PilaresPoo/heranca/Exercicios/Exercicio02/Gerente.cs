using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Gerente : Funcionario
    {
        public int Bonus = 5000;

        public float CalcularBonus()
        {
            return SalarioBase += Bonus;
        }
    }
}