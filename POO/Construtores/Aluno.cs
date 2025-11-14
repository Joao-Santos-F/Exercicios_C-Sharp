using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Aluno
    {
        public string nome;
        public int nota;

        public Aluno()
        {
            Console.WriteLine($"Aluno registrado");

        }

        public Aluno(string no, int not)
        {
            nome = no;
            nota = not;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome}  |  Nota: {nota}");
        }

    }

}