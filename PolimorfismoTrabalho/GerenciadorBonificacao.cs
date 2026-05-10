using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PolimorfismoTrabalho;

public class GerenciadorBonificacao
{
    public double TotaldeBonificacao { get; private set; }

    public void TotalizadorBonificacao(Funcionario funcionario)
    {
        TotaldeBonificacao += funcionario.CalcularBonificacao();
    }

    public void TotalizadorBonificacao(Secretario secretario)
    {
        TotaldeBonificacao += secretario.CalcularBonificacao();
    }

    public void TotalizadorBonificacao(Gerente gerente)
    {
        TotaldeBonificacao += gerente.CalcularBonificacao();
    }

    public void TotalizadorBonificacao(Diretor diretor)
    {
        TotaldeBonificacao += diretor.CalcularBonificacao();
    }
}
