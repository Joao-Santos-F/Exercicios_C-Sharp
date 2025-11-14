using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Funcionario
    {
        public string nome = "";

        public int SalarioBase = 1852;

        public float CalcularSalario()
        {
            return SalarioBase;
        }
    }
}