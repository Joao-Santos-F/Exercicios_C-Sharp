using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseEObjetos
{
    public class Produto
    {
        public string nome = "";
        public double preco;

        public void Desconto(double porcentual)
        {
            if (porcentual > 100)
            {
                Console.WriteLine($"Desconto indisponível por ultrapassar o preco original.");
            }
            else
            {
                preco -= preco / 100 * porcentual;
            }
        }

    }
}