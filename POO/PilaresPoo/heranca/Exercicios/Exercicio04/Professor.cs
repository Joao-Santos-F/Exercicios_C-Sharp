using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Professor : Pessoa
    {
        public string Disciplina;

        public void ProfessorRegistrado()
        {
            Console.WriteLine($"O professor {Nome}, com a disciplina {Disciplina} tem {Idade}");
        }
    }
}