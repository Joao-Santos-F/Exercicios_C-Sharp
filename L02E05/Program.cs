int macas;

float preco1 = 0.30f;
float preco2 = 0.25f;
float conta;

Console.WriteLine("Quantas maças voce comprou?");
macas = int.Parse(Console.ReadLine());

Console.Clear();

if (macas <= 12)
{
    conta = macas * preco1;
    Console.WriteLine($"Sua compra final deu R${conta}");
}
else
{
    conta = macas * preco2;
    Console.WriteLine($"Sua compra final deu R${conta}");
}