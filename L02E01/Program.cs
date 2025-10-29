float salario;
float gasto;
float resultado;

Console.WriteLine("Digite o seu salário");
salario = float.Parse(Console.ReadLine());

Console.WriteLine("Digite qual foi seu gasto");
gasto = float.Parse(Console.ReadLine());

resultado = salario - gasto;

if (resultado > 0)
{
    Console.WriteLine($"O seu gasto foi positivo, ainda te resta {resultado}");
}
else
{
    Console.WriteLine($"O seu gasto foi negativo, está devendo {resultado}");
}