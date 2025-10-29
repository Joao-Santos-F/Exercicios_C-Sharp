int time1;
int time2;

Console.WriteLine("Qual foi o placar do time da casa?");
time1 = int.Parse(Console.ReadLine());

Console.WriteLine("Qual foi o placar do time visitante?");
time2 = int.Parse(Console.ReadLine());

Console.Clear();

if (time1 > time2)
{
    Console.WriteLine($"O time da casa venceu de {time1} a {time2}");
}
else if (time1 == time2)
{
    Console.WriteLine($"O jogo deu empate, sendo {time1} a {time2}");
}
else
{
    Console.WriteLine($"O time visitante venceu de {time2} a {time1}");
}