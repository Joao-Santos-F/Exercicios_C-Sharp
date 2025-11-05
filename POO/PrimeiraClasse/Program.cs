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

// Garrafa seila = new Garrafa();
// seila.Cor = "Roxa";
// seila.Capacidade = 500;
// seila.Tamando = 27;
// seila.Formato = "Arredondada";
// seila.abrir();
// seila.beber();

// Garrafa Stanley = new Garrafa();
// Stanley.Cor = "Cinza";
// Stanley.Capacidade = 500;
// Stanley.Tamando = 30;
// Stanley.Formato = "Cilíndrico";
// Stanley.abrir();
// Stanley.beber();

// Console.Write($"Abrindo a garrafa Stanley: ");
// Stanley.abrir();

// Console.Write($"Bebendo água da garrafa Stanley: ");
// Stanley.beber();

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
else if (nova.idade <= 0)
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
nova.despedir();
nova.dormindo();
nova.envelhecer(10);