int senha = 1234;
int senhatentada;
int tentativas = 3;

Console.WriteLine("Qual a sua senha para acessar a conta?");
senhatentada = int.Parse(Console.ReadLine());

Console.Clear();

if (senhatentada == senha)
{
    Console.WriteLine("Senha correta, acesso a conta permitido");
}
else
{
    Console.WriteLine("Senha incorreta, acesso a conta negado");
}