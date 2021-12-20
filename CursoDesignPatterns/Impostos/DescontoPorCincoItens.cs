using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
   public class DescontoPorCincoItens : IDesconta
    {
        public IDesconta Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconto(orcamento);
        }
    }
}
