namespace Construtores
{
    public class Livro
    {
        public string titulo;
        public string autor;
        public float preco;

        public Livro(string t, string a, float p)
        {
            titulo = t;
            autor = a;
            preco = p;
        }

        public Livro(string ti, string au)
        {
            titulo = ti;
            autor = au;
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Titulo - {titulo}");
            Console.WriteLine($"Autor - {autor}");
            Console.WriteLine($"Preço - {preco}");
            
        }
    }
}