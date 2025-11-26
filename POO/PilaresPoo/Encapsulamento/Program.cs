using Encapsulamento;

ContaBancaria ContaJao = new ContaBancaria();
ContaBancaria ContaRaf = new ContaBancaria(1500);

ContaJao.Depositar(-100);
ContaJao.Depositar(20);
ContaJao.Sacar(-200);
ContaRaf.Sacar(300);

Console.WriteLine($"Saldo atual: {ContaJao.GetSaldo}");
Console.WriteLine($"Saldo atual: {ContaRaf.GetSaldo}");
