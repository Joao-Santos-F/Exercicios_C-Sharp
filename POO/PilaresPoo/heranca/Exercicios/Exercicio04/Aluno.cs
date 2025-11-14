using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Aluno : Pessoa
    {
        public string Curso;

        public void AlunoRegistrado()
        {
            Console.WriteLine($"O aluno {Nome}, faz o curso de {Curso} com {Idade} anos");
        }
    }
}