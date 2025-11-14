using Exerciciopolimorfismo;

PagamentoPix comprapix = new PagamentoPix();
comprapix.ValorCompra = 15000;

float valorpagar = comprapix.CalcularTotal();
Console.WriteLine($"Produto: Iphone");
Console.WriteLine($"Preco: {comprapix.ValorCompra}");
Console.WriteLine($"Pagamento com Desconto: {valorpagar}");
Console.WriteLine($"");

PagamentoCartao  compracartao = new PagamentoCartao();
compracartao.ValorCompra = 50;

Console.WriteLine($"Produto: Caneca");
Console.WriteLine($"Preco: {compracartao.ValorCompra}");
Console.WriteLine($"Forma De Pagamento: Cartao");
Console.WriteLine($"Pagamento com Acrescimo: {compracartao.CalcularTotal()}");
Console.WriteLine($"");