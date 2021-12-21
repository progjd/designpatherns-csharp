using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
   public class ContaNegativa : EstadoDaConta
    {
        public void Saca(ContaTwo contatwo, double valor)
        {
            throw new Exception("Conta negativa nao e possivel sacar");
        }
        public void Deposita(ContaTwo contatwo, double valor)
        {
            contatwo.Saldo += valor * 0.95;
            if (contatwo.Saldo > 0) contatwo.Estado = new ContaPositiva();
        }
    }
}
