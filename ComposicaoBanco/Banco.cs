using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Banco
    {
        private Poupanca[] poups;
        private ContaCorrente[] contas;
        private int qtdPoups;
        private int qtdContas;
        public string Nome { get; private set; }

        public Banco(string nome, int capacidadeContas, int capacidadePoups)
        {
            Nome = nome;
            poups = new Poupanca[capacidadePoups];
            contas = new ContaCorrente[capacidadeContas];
            qtdPoups = 0;
            qtdContas = 0;
        }

        public void IniciarBanco()
        {
            Console.WriteLine($"Banco {Nome} iniciado com sucesso.");
        }

        public void AbrirConta(double saldoInicial, double chequeEspecial)
        {
            if (qtdContas < contas.Length)
            {
                contas[qtdContas] = new ContaCorrente(saldoInicial, chequeEspecial);
                qtdContas++;
                Console.WriteLine("Conta corrente aberta com sucesso.");
            }
            else
            {
                Console.WriteLine("Limite de contas correntes atingido.");
            }
        }

        public void AbrirPoupanca(double saldoInicial)
        {
            if (qtdPoups < poups.Length)
            {
                poups[qtdPoups] = new Poupanca(saldoInicial);
                qtdPoups++;
                Console.WriteLine("Conta poupança aberta com sucesso.");
            }
            else
            {
                Console.WriteLine("Limite de contas poupança atingido.");
            }
        }

        public ContaCorrente ObterConta(int indice)
        {
            if (indice >= 0 && indice < qtdContas)
                return contas[indice];

            return null;
        }

        public Poupanca ObterPoupanca(int indice)
        {
            if (indice >= 0 && indice < qtdPoups)
                return poups[indice];

            return null;
        }

        public void ListarContas()
        {
            Console.WriteLine("\n=== CONTAS CORRENTES ===");
            for (int i = 0; i < qtdContas; i++)
            {
                Console.WriteLine($"Conta Corrente {i + 1}:");
                contas[i].GerarExtrato();
                Console.WriteLine();
            }

            Console.WriteLine("=== CONTAS POUPANÇA ===");
            for (int i = 0; i < qtdPoups; i++)
            {
                Console.WriteLine($"Poupança {i + 1}:");
                Console.WriteLine($"Saldo: R$ {poups[i].Saldo:F2}");
                Console.WriteLine();
            }
        }

        public void DecretarFalencia()
        {
            poups = new Poupanca[0];
            contas = new ContaCorrente[0];
            qtdPoups = 0;
            qtdContas = 0;

            Console.WriteLine($"O banco {Nome} decretou falência.");
        }
    }
}