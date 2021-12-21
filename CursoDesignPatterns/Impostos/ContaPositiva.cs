using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
   public class ContaPositiva : EstadoDaConta
    {
        public void Saca(ContaTwo contatwo, double valor)
        {
            contatwo.Saldo -= valor;
            if (contatwo.Saldo < 0 ) contatwo.Estado = new ContaNegativa();

        }
        public void Deposita(ContaTwo contatwo, double valor)
        {
            contatwo.Saldo += valor * 0.98;
        }

    }
}
