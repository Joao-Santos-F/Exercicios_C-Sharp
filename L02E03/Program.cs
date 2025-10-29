float medida1;
float medida2;

Console.WriteLine("Quantos lados iguais o seu triângulo possui?");
medida1 = float.Parse(Console.ReadLine());

Console.WriteLine("O seu triângulo possui quantos lados diferentes?");
medida2 = float.Parse(Console.ReadLine());

Console.Clear();

if (medida1 == 3 && medida2 == 0)
{
    Console.WriteLine("Triângulo Equilátero");
}
else if (medida1 == 2 && medida2 == 0)
{
    Console.WriteLine("Triângulo Isóscele");
}
else if (medida1 == 0 && medida2 == 3)
{
    Console.WriteLine("Triângulo Escaleno");
}
else
{
    Console.WriteLine("Perdão, o programador não entende de formas geométricas");
}