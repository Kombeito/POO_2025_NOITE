using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using PolimorfismoTrabalho;

var funcionario = new Funcionario(1, "Funcionário Comum", 3000.00);
var secretario = new Secretario(2, "Secretária", 3500.00);
var gerente = new Gerente(3, "Gerente", 8000.00);
var diretor = new Diretor(4, "Diretor", 15000.00);

var gerenciador = new GerenciadorBonificacao();

gerenciador.TotalizadorBonificacao(funcionario);
gerenciador.TotalizadorBonificacao(secretario);
gerenciador.TotalizadorBonificacao(gerente);
gerenciador.TotalizadorBonificacao(diretor);

Console.WriteLine("Bonificações individuais:");
Console.WriteLine(funcionario);
Console.WriteLine(secretario);
Console.WriteLine(gerente);
Console.WriteLine(diretor);

Console.WriteLine();
Console.WriteLine($"Total de bonificação: R$ {gerenciador.TotaldeBonificacao:F2}");
