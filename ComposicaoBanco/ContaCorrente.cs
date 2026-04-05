using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComposicaoBanco
{
    public class ContaCorrente
    {
        private double saldo;
        private double chequeEspecial;

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

        public double ChequeEspecial
        {
            get { return chequeEspecial; }
            private set
            {
                if (value >= 0)
                    chequeEspecial = value;
                else
                    chequeEspecial = 0;
            }
        }

        public ContaCorrente(double saldoInicial, double limiteChequeEspecial)
        {
            Saldo = saldoInicial;
            ChequeEspecial = limiteChequeEspecial;
        }

        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                Console.WriteLine($"Depósito de R$ {valor:F2} realizado na conta corrente.");
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

            if (valor <= Saldo + ChequeEspecial)
            {
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                }
                else
                {
                    double restante = valor - Saldo;
                    Saldo = 0;
                    ChequeEspecial -= restante;
                }

                Console.WriteLine($"Saque de R$ {valor:F2} realizado na conta corrente.");
            }
            else
            {
                Console.WriteLine("Saldo + cheque especial insuficientes.");
            }
        }

        public void GerarExtrato()
        {
            Console.WriteLine("=== Extrato Conta Corrente ===");
            Console.WriteLine($"Saldo: R$ {Saldo:F2}");
            Console.WriteLine($"Cheque especial disponível: R$ {ChequeEspecial:F2}");
        }
    }
}