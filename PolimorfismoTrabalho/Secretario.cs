using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoTrabalho;

public class Secretario : Funcionario
{
    public Secretario(int codigo, string nome, double salario)
        : base(codigo, nome, salario)
    {
    }

    public override double CalcularBonificacao()
    {
        return base.CalcularBonificacao();
    }
}
