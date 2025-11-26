using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Contrato : IImprimir
    {
        public string Nome;
        public string TextoClausulas;

        public Contrato(string NomeEmpresa, string Clausulas)
        {
            Nome = NomeEmpresa;
            TextoClausulas = Clausulas;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Nome do contrato: {Nome}");
            Console.WriteLine($"Clausula do contrato: {TextoClausulas}");
            
            
        }
    }
}