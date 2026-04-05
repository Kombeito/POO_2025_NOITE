using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class Poupanca
    {
        private double saldo;

        public double Saldo
        {
            get { return saldo; }
            private set
            {
                if (value >= 0)
                    saldo = value;
                else
                    saldo = 0;
            }
        }

        public Poupanca(double saldoInicial)
        {
            Saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado na poupança.");
            }
            else
            {
                Console.WriteLine("Valor de depósito inválido.");
            }
        }

        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("Valor de saque inválido.");
                return;
            }

            if (valor <= Saldo)
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de R$ {valor:F2} realizado na poupança.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente na poupança.");
            }
        }

        public void GerarRendimento()
        {
            double rendimento = Saldo * 0.005;
            Saldo += rendimento;
            Console.WriteLine($"Rendimento de R$ {rendimento:F2} gerado na poupança.");
        }
    }
}