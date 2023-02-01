using System;
using System.Globalization;

namespace ExemploProduto;

    class Program
{
    static void Main(string[] args)
    {
        Produto p = new Produto();
        
        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome do produto: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço do produto: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade do produto: ");
        p.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Os dados do produto são: " + p);
        
        Console.WriteLine();
        Console.WriteLine("Digite o número de produtos a serem acrescentados: ");
        Console.WriteLine();
        int qte = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(qte);

        Console.WriteLine();
        Console.WriteLine("Dados atualizados: "+ p);
        Console.WriteLine();
        Console.WriteLine("Digite o número de produtos a serem retirados: ");
        Console.WriteLine();
        int ret = int.Parse(Console.ReadLine());
        p.RemoverProdutos(ret);
        Console.WriteLine("Dados atualizados: " + p);





    }
}