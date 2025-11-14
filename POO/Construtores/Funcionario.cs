using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Funcionario
    {
        public string nome;
        public string cargo;
        public float salario;

        public Funcionario(string n)
        {
            nome = n;
        }
        public Funcionario(string n, string c)
        {
            nome = n;
            cargo = c;
        }
        public Funcionario(string n, string c, float s)
        {
            nome = n;
            cargo = c;
            salario = s;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"O funcionário {nome}, que ocupa o cargo {cargo} e recebe R${salario}");
        }
    }
}