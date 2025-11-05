using System.Data;

Console.WriteLine($"-------------------------"); 
Console.WriteLine($"Seja Bem-Vindo, usuario"); 
Console.WriteLine($"-------------------------");

// Declarar os métodos antes do loop (ou mover para depois com assinatura)
void opcao1()
{
    Console.WriteLine("Opcao 1");
}

void opcao2()
{
    Console.WriteLine("opcao 2");
}

int entrada;

do
{
    // Menu de opções
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Opção 1");
    Console.WriteLine("2 - Opção 2");
    Console.WriteLine("0 - Sair");
    entrada = int.Parse(Console.ReadLine());

    switch (entrada)
    {
        case 1:
            opcao1();
            break;
        case 2:
            opcao2();
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    
} while (entrada != 0);