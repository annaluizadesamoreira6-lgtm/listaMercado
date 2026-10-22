
using System.Collections.Generic;

// Criando lista de produtos dinamica
//(comecando vazia , e vai colocando informacoes conforme o usuario digita)
List<double> precosProdutos = new List<double>();

Console.WriteLine("=== MERCADINHO: REGISTRO DE COMPRAS ===");


double precosDigitado = -1;

//Laco de repetiçao para inserçao de valores pelo usuario 
while (precosDigitado != 0 )
{
    Console.WriteLine("Para finalizar digite '0'");
    Console.WriteLine("Digite o preco do preoduto:R$");
    precosDigitado = double.Parse(Console.ReadLine());

    if(precosDigitado > 0)
    {
        precosProdutos.Add(precosDigitado);
    }
}


double valorTotal = CalcularTotalCompra(precosProdutos);

Console.WriteLine("==================================");
Console.WriteLine($"Quantidade de items compredo :{precosProdutos.Count}");
Console.WriteLine($"Valor total a pagar a pagarR${valorTotal}");
Console.WriteLine("===================================");

 //fucao percorre a lis com os precos por párametro soma-os e RETORNA o total
 static double CalcularTotalCompra(List<double> listaPrecos)
{
    
    double soma = 0;

    //o foreach percorre cada item da lista automaticamente (foreach-forma simplificada por)
    foreach (double preco in listaPrecos)
    {
        soma += preco;
    }
    return soma;
}
