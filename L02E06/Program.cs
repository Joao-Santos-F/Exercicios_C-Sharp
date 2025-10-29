float media;
float presenca;

Console.WriteLine("Qual foi sua média final?");
media = float.Parse(Console.ReadLine());

Console.WriteLine("Qual foi sua % de frequência?");
presenca = float.Parse(Console.ReadLine());

Console.Clear();

if (media >= 7 && presenca >= 75)
{
    Console.WriteLine($"Voce foi aprovado com média de {media} e presença de {presenca}%");
}
else if (media >= 3 && media < 7 && presenca >= 75)
{
    Console.WriteLine($"Voce ficou de recuperação com média de {media} e presença de {presenca}%");
}
else
{
    Console.WriteLine($"Voce foi reprovado, com média de {media} e presença de {presenca}%");
}