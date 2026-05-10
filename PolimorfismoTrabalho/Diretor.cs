using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoTrabalho;

public class Diretor : Funcionario
{
    public Diretor(int codigo, string nome, double salario)
        : base(codigo, nome, salario)
    {
    }

    public override double CalcularBonificacao()
    {
        return (salario * 0.10) + 1000.0;
    }
}
