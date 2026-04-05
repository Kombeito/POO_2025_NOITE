using System;
using ComposicaoBanco;

internal class Program
{
    private static void Main()
    {
        Banco banco = new Banco("FatecBank", 5, 5);

        banco.IniciarBanco();

        banco.AbrirConta(1000, 500);
        banco.AbrirConta(2000, 800);

        banco.AbrirPoupanca(1500);
        banco.AbrirPoupanca(3000);

        ContaCorrente conta1 = banco.ObterConta(0);
        ContaCorrente conta2 = banco.ObterConta(1);

        Poupanca poup1 = banco.ObterPoupanca(0);
        Poupanca poup2 = banco.ObterPoupanca(1);

        if (conta1 != null)
        {
            conta1.Depositar(300);
            conta1.Sacar(1200);
            conta1.GerarExtrato();
        }

        if (conta2 != null)
        {
            conta2.Sacar(2500);
            conta2.GerarExtrato();
        }

        if (poup1 != null)
        {
            poup1.Depositar(200);
            poup1.Sacar(100);
            poup1.GerarRendimento();
        }

        if (poup2 != null)
        {
            poup2.GerarRendimento();
        }

        banco.ListarContas();
    }
}