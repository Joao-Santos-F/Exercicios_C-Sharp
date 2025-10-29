int opcao;

Console.WriteLine("----------------");
Console.WriteLine($"   Bem-vindo   ");
Console.WriteLine($"      ao       ");
Console.WriteLine($"Итаим Паулиста");
Console.WriteLine("----------------");

do
{
    Console.WriteLine("01 - Feijoada .......R$24,99");
    Console.WriteLine("02 - Baião de Dois .......R$24,99");
    Console.WriteLine("03 - Tapioca .......R$24,99");
    Console.WriteLine("04 - Coxinha .......R$24,99");
    Console.WriteLine("05 - Frango a Milanesa .......R$24,99");
    Console.WriteLine("06 - Picanha .......R$24,99");
    Console.WriteLine("07 - Bife .......R$24,99");
    Console.WriteLine("08 - Cupim de Boi .......R$24,99");
    Console.WriteLine("09 - Linguiça .......R$24,99");
    Console.WriteLine("0 - sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 01:
            Console.WriteLine($"Opção escolhida - {opcao} Feijoada .......R$24,99");
            Thread.Sleep(1500);
            break;

        case 02:
            Console.WriteLine($"Opção escolhida - {opcao} Baião de Dois .......R$24,99");
            Thread.Sleep(1500);
            break;

        case 03:
            Console.WriteLine($"Opção escolhida - {opcao} Tapioca .......R$24,99");
            Thread.Sleep(1500);
            break;

        case 04:
            Console.WriteLine($"Opção escolhida - {opcao} Coxinha .......R$24,99");
            Thread.Sleep(1500);
            break;

        case 05:
            Console.WriteLine($"Opção escolhida - {opcao} Frango a Milanesa .......R$24,99");
            Thread.Sleep(1500);
            break;

        case 06:
            Console.WriteLine($"Opção escolhida - {opcao} Picanha .......R$24,99");
            Thread.Sleep(1500);
            break;

        case 07:
            Console.WriteLine($"Opção escolhida - {opcao} Bife .......R$24,99");
            Thread.Sleep(1500);
            break;

        case 08:
            Console.WriteLine($"Opção escolhida - {opcao} Cupim de Boi .......R$24,99");
            Thread.Sleep(1500);
            break;

        case 09:
            Console.WriteLine($"Opção escolhida - {opcao} Linguiça .......R$24,99");
            Thread.Sleep(1500);
            break;

        default:
            Console.WriteLine("opção inválida no momento");
            Thread.Sleep(1500);
            break;
    }

    Console.WriteLine($"Digite <Enter> para continuar...");
    Console.ReadLine();
    

} while (opcao != 0);