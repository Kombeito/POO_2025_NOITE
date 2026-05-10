using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoTrabalho;

public class Funcionario
{
    protected int codigo;
    protected string nome;
    protected double salario;

    public int Codigo => codigo;
    public string Nome => nome;
    public double Salario => salario;

    public Funcionario(int codigo, string nome, double salario)
    {
        this.codigo = codigo;
        this.nome = nome;
        this.salario = salario;
    }

    public virtual double CalcularBonificacao()
    {
        return salario * 0.10;
    }

    public override string ToString()
    {
        return $"{codigo} - {nome} | Salário: R$ {salario:F2} | Bonificação: R$ {CalcularBonificacao():F2}";
    }
}
