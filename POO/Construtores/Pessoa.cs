namespace Construtores
{
    public class Pessoa
    {
        //atributos/propriedades
        public string Nome;
        public int Idade;

        public Pessoa()
        {
            Console.WriteLine($"Objeto criado !");
        }

        public Pessoa(string n, int i)
        {
            Nome = n;
            Idade = i;
        }

        //métodos
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");

        }
    }
}