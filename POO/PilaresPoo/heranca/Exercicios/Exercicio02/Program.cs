using heranca;

Funcionario Everson = new Funcionario();
Gerente Cleber = new Gerente();

Everson.SalarioBase = 1000;
Cleber.SalarioBase = 10000;

float SalFinalComun = Everson.CalcularSalario();
float SalFinalGen = Cleber.CalcularBonus();

Console.WriteLine($"Salário do funcionário R${SalFinalComun}");
Console.WriteLine($"Salário do gerente R${SalFinalGen}");
