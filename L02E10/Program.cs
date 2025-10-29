int opcao;

void ControleFinanceiro()
{
    float salario;
    float gasto;
    float resultado;

    Console.WriteLine("CONTROLE FINANCEIRO");
    Console.WriteLine("Digite o seu salário:");
    salario = float.Parse(Console.ReadLine());

    Console.WriteLine("Digite qual foi seu gasto:");
    gasto = float.Parse(Console.ReadLine());

    resultado = salario - gasto;

    if (resultado > 0)
    {
        Console.WriteLine($"O seu gasto foi positivo, ainda te resta R${resultado:F2}");
    }
    else
    {
        Console.WriteLine($"O seu gasto foi negativo, está devendo R${resultado:F2}");
    }
}

void PlacarFutebol()
{
    int time1;
    int time2;

    Console.WriteLine("PLACAR DE FUTEBOL");
    Console.WriteLine("Qual foi o placar do time da casa:");
    time1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Qual foi o placar do time visitante:");
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
}

void ClassificacaoTriangulos()
{
    float medida1;
    float medida2;

    Console.WriteLine("CLASSIFICAÇÃO DE TRIÂNGULOS");
    Console.WriteLine("Quantos lados iguais o seu triângulo possui?");
    medida1 = float.Parse(Console.ReadLine());

    Console.WriteLine("O seu triângulo possui quantos lados diferentes?");
    medida2 = float.Parse(Console.ReadLine());

    Console.Clear();

    if (medida1 == 3 && medida2 == 0)
    {
        Console.WriteLine("Triângulo Equilátero");
    }
    else if (medida1 == 2 && medida2 == 1)
    {
        Console.WriteLine("Triângulo Isósceles");
    }
    else if (medida1 == 0 && medida2 == 3)
    {
        Console.WriteLine("Triângulo Escaleno");
    }
    else
    {
        Console.WriteLine("Perdão, o programador não entende de formas geométricas");
    }
}

void ValidacaoSenha()
{
    int senha = 1234;
    int senhatentada;
    int tentativas = 3;

    Console.WriteLine("VALIDAÇÃO DE SENHA");
    Console.WriteLine("Qual a sua senha para acessar a conta:");
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
}

void CompraMacas()
{
    int macas;
    float preco1 = 0.30f;
    float preco2 = 0.25f;
    float conta;

    Console.WriteLine("COMPRA DE MAÇÃS");
    Console.WriteLine("Quantas maçãs você comprou?");
    macas = int.Parse(Console.ReadLine());

    Console.Clear();

    if (macas <= 12)
    {
        conta = macas * preco1;
        Console.WriteLine($"Sua compra final deu R${conta:F2}");
    }
    else
    {
        conta = macas * preco2;
        Console.WriteLine($"Sua compra final deu R${conta:F2}");
    }
}

void SituacaoEscolar()
{
    float media;
    float presence;

    Console.WriteLine("SITUAÇÃO ESCOLAR");
    Console.WriteLine("Qual foi sua média final?");
    media = float.Parse(Console.ReadLine());

    Console.WriteLine("Qual foi sua % de frequência?");
    presence = float.Parse(Console.ReadLine());

    Console.Clear();

    if (media >= 7 && presence >= 75)
    {
        Console.WriteLine($"Você foi aprovado com média de {media} e presença de {presence}%");
    }
    else if (media >= 3 && media < 7 && presence >= 75)
    {
        Console.WriteLine($"Você ficou de recuperação com média de {media} e presença de {presence}%");
    }
    else
    {
        Console.WriteLine($"Você foi reprovado, com média de {media} e presença de {presence}%");
    }
}

do
{
    Console.Clear();
    Console.WriteLine("SISTEMA DE PROGRAMAS");
    Console.WriteLine("1 - Controle Financeiro");
    Console.WriteLine("2 - Placar de Futebol");
    Console.WriteLine("3 - Classificação de Triângulos");
    Console.WriteLine("4 - Validação de Senha");
    Console.WriteLine("5 - Compra de Maçãs");
    Console.WriteLine("6 - Situação Escolar");
    Console.WriteLine("0 - Sair");
    Console.Write("Escolha uma opção: ");

    opcao = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcao)
    {
        case 1:
            ControleFinanceiro();
            break;
        case 2:
            PlacarFutebol();
            break;
        case 3:
            ClassificacaoTriangulos();
            break;
        case 4:
            ValidacaoSenha();
            break;
        case 5:
            CompraMacas();
            break;
        case 6:
            SituacaoEscolar();
            break;
        case 0:
            Console.WriteLine("Saindo do sistema...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine("Pressione qualquer tecla para continuar...");
        Console.ReadKey();
    }

} while (opcao != 0);