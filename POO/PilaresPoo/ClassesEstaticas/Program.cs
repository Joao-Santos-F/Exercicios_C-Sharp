using System.Reflection.Metadata.Ecma335;
using ClassesEstaticas;

Console.WriteLine($"O número de PI é igual {CalculosMatematicos.PI}");

Console.WriteLine($"Escolha um número");
float x = float.Parse(Console.ReadLine());

Console.WriteLine($"Escolha um outro número");
float y = float.Parse(Console.ReadLine());

float maior = Math.Max(x, y);
float menor = Math.Min(x, y);

if (maior == menor)
{
    Console.WriteLine($"O dois números são iguais");
    return;
}

Console.WriteLine($"O maior número escolhido foi {maior}");
Console.WriteLine($"O menor número escolhido foi {menor}");