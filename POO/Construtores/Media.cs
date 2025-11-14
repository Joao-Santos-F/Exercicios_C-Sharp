using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Media
    {
        public string nome;
        public float nota1, nota2, nota3;
        public float media;

        public Media(string n, float n1, float n2, float n3)
        {
            nome = n;
            nota1 = n1;
            nota2 = n2;
            nota3 = n3;
        }

        public Media()
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
        }

        public void ExibirDados()
        {
            media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine($"A sua média nesse semestre foi {media}");
            
        }
    }
    
}