using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoTrabalho;

public class Gerente : Funcionario
{
    public Gerente(int codigo, string nome, double salario)
        : base(codigo, nome, salario)
    {
    }

    public override double CalcularBonificacao()
    {
        return salario * 0.15;
    }
}
