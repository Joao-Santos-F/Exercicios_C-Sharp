using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;
using PrimeiraClasse;

// Console.WriteLine($" ==== PROGRAMA PRIMEIRA CLASSE ====");

// Carro Mclaren = new Carro();
// Mclaren.Marca = "McLaren";
// Mclaren.Cor = "Laranja";
// Mclaren.Modelo = "750S";
// Mclaren.Potencia = 800;

// Console.WriteLine($"Ligando a {Mclaren.Marca} {Mclaren.Cor}");
// Mclaren.ligar();
// Console.WriteLine($"Aceleradno a {Mclaren.Marca} de {Mclaren.Potencia} Cv");
//Mclaren.Acelerar();

pessoa nova = new pessoa();
nova.nome = "";
nova.idade = 0;
nova.altura = 0;

Console.WriteLine($"Qual o seu nome?");
nova.nome = Console.ReadLine();

Console.WriteLine($"Qual a sua idade?");
nova.idade = int.Parse(Console.ReadLine());

if (nova.idade >= 120)
{
    Console.WriteLine($"Tu é um vampiro? Digita sua idade certa.");
    return;
}
else if (nova.idade <=0)
{
    Console.WriteLine($"Tu acabou de nascer? Digita sua idade certa.");
    return;
}

Console.WriteLine($"Qual a sua altura?");
nova.altura = float.Parse(Console.ReadLine());

if (nova.altura > 3)
{
    Console.WriteLine($"Tu é um prédio? Digita sua altura certa.");
    return;
}
else if (nova.altura <= 0.50)
{
    Console.WriteLine($"Tu é um cachorro? Digita sua altura certa.");
    return;
}

Console.Clear();

nova.Ola();
nova.tchau();
nova.dormindo();
nova.acordando();