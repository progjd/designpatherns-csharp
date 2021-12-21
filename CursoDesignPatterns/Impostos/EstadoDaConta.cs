using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
   public interface EstadoDaConta
    {
        void Saca(ContaTwo contatwo, double valor);
        void Deposita(ContaTwo contatwo, double valor);
    }
}
