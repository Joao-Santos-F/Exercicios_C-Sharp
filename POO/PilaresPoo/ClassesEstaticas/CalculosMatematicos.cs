using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public static class CalculosMatematicos
    {
        public static double PI = 3.14159265359;

        public static float Somar(float x, float y)
        {
            return x + y;
        }

        public static float Subtracao(float x, float y)
        {
            return x - y;
        }

        public static float Multiplicacao(float x, float y)
        {
            return x * y;
        }

        public static float Divisao(float x, float y)
        {

            if (y == 0)
            {
                Console.WriteLine($"O número não pode ser dividido por zero");
            }
            
            return x / y;
        }
    }
}