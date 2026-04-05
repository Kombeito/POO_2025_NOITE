using System;
using AgragacaoVenda;

internal class Program
{
    private static void Main()
    {
        Vendedor vendedor = new Vendedor("Robinston");
        Comprador comprador = new Comprador("Alec", 2000);

        Produto p1 = new Produto("PC Gaymer", 1500);
        Produto p2 = new Produto("Bomba Para Treino", 120);
        Produto p3 = new Produto("Jack Daniel's", 250);

        Venda venda = new Venda(comprador, vendedor);

        venda.RealizarVenda(p1);
        venda.RealizarVenda(p2);
        venda.RealizarVenda(p3);

        venda.MostrarResumo();
// outra venda
        Venda venda2 = new Venda(comprador, vendedor);

        venda2.RealizarVenda(p1);
        venda2.RealizarVenda(p2);
        venda2.RealizarVenda(p3);

        venda2.MostrarResumo();

    }
}