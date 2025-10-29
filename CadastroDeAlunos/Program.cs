string[] nomes = new string[3];
int[] idades = new int[3];
int opcao = -1;
int totalAlunos = 0;

do
{
    Console.Clear();
    Console.WriteLine($"=== Aplicativo Sala de Aula ===");
    Console.WriteLine($" 1) Listar Alunos");
    Console.WriteLine($" 2) Cadastrar Alunos");
    Console.WriteLine($" 0) Sair");
    Console.WriteLine($"Escolha uma opcao");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando....");
            break;
        case 1:
            ListarAluno();
            break;
        case 2:
            CadastrarAluno();
            break;
        default:
            break;
    }

    Console.WriteLine($"Pressione <ENTER> para continuar ...");
    Console.ReadLine();

} while (opcao != 0);

void ListarAluno()
{
    Console.WriteLine("=== Listagem de Alunos ===");
    
    if (totalAlunos == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado.");
    }
    else
    {
        for (int i = 0; i < totalAlunos; i++)
        {
            Console.WriteLine($"Aluno {i + 1}: {nomes[i]}  Idade: {idades[i]} anos");
        }
    }
}

void CadastrarAluno()
{
    Console.WriteLine("=== Cadastro de Alunos ===");

    if (totalAlunos >= 3)
    {
        Console.WriteLine($"Limite de vagas atingido");
        return;
    }
     
    Console.WriteLine($"Digite o nome do aluno:");
    string nome = Console.ReadLine();
    nomes[totalAlunos] = nome;

    Console.WriteLine($"Digite a idade do {nome}:");
    idades[totalAlunos] = int.Parse(Console.ReadLine());

    totalAlunos++;
    Console.WriteLine($"Aluno {nome} cadastrado com sucesso!");
}