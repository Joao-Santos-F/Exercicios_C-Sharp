using heranca;

Carro Fusca = new Carro();
Veiculo Generic = new Veiculo();
Fusca.Marca = "Volkswagen";
Fusca.Modelo = "Fusca";
Fusca.Ano = 1959;
Fusca.QtdPortas = 2;
Fusca.Acelerar();
Fusca.ExibirInfo();

Thread.Sleep(2250);

Console.Clear();

Moto Honda = new Moto();
Honda.Marca = "Honda";
Honda.Modelo = "Honda CB 650R";
Honda.Ano = 2023;
Honda.Cilindradas = 649;
Honda.SomDaMoto();
Honda.Acelerar();
Honda.ExibirInfo();

Thread.Sleep(2250);

Console.Clear();

Aviao Boeing = new Aviao();
Boeing.Modelo = "Boeing 737 MAX 8";
Boeing.Marca = "Boeing";
Boeing.Ano = 2023;
Boeing.QTDAsas = 2;
Boeing.Voar();
Boeing.ExibirInfo();