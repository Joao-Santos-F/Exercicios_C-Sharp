using System.Runtime.CompilerServices;
using ClasseEObjetos;

// Garrafa stanley = new Garrafa();
// stanley.Cor = "";
// stanley.Capacidade = 0;
// stanley.Formato = "";
// stanley.Tamando = 0;

// string nome = "";

// Console.WriteLine($"Qual o seu nome?");
// nome = Console.ReadLine();

// Console.WriteLine($"Qual a Cor da sua garrafa?");
// stanley.Cor = Console.ReadLine();

// Console.WriteLine($"Qual a Capacidade da sua garrafa?");
// stanley.Capacidade = int.Parse(Console.ReadLine());

// if (stanley.Capacidade == 69)
// {
//     Console.WriteLine($"Não existe garrafa de 69 Mililitros");
//     return;
// }
// else if (stanley.Capacidade == 67)
// {
//     Console.WriteLine($"Teu cérebro já está pior que o rio tietê");
//     return;
// }

// Console.WriteLine($"Qual o formato de sua garrafa?");
// stanley.Formato = Console.ReadLine();

// Console.WriteLine($"Qual o tamanho da sua garrafa?");
// stanley.Tamando = int.Parse(Console.ReadLine());

// if (stanley.Tamando == 69)
// {
//     Console.WriteLine($"Tá aí o motivo dela ter te largado");
//     return;
// }
// else if (stanley.Tamando == 67)
// {
//     Console.WriteLine($"Cara, se tu quer cursar medicina, desiste enquanto dá tempo");
//     return;
// }

// Console.WriteLine($"Olá {nome} sua garrafa de cor {stanley.Cor}, tem capacidade de {stanley.Capacidade}ML, tem o formato {stanley.Formato} e tamanho {stanley.Tamando}Cm");

// stanley.abrir();
// stanley.beber();

// Thread.Sleep(1500);

// stanley.acabou();



// AgenciaBancária nova = new AgenciaBancária();
// nova.Titular = "";
// nova.Saldo = 1000;

// Console.WriteLine($"Qual o seu nome?");
// nova.Titular = Console.ReadLine();

// Console.Clear();

// Console.WriteLine($"{nova.Titular} tem {nova.Saldo}R$");

// Console.WriteLine($"Quanto voce deseja sacar?");
// nova.Sacar(float.Parse(Console.ReadLine()));

// Console.Clear();

// Console.WriteLine($"{nova.Titular} tem {nova.Saldo}R$");

// Console.WriteLine($"Quanto voce deseja depositar?");
// nova.Deposito(float.Parse(Console.ReadLine()));

// Console.Clear();

// Console.WriteLine($"{nova.Titular} tem {nova.Saldo}R$");



Produto produto = new Produto();
produto.nome = "";
produto.preco = 0;

Console.WriteLine($"Qual o nome do produto que procura?");
produto.nome = Console.ReadLine();

Console.WriteLine($"Qual o preço do produto que procura?");
produto.preco = double.Parse(Console.ReadLine());

Console.WriteLine($"Qual o desconto do produto no momento?");
produto.Desconto(double.Parse(Console.ReadLine()));

Console.WriteLine($"Desconto aplicado, novo preco {produto.preco}R$");