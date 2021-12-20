using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class DescontoPorMaisQuinhentos : IDesconta
    {
        public IDesconta Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
             if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.Desconto(orcamento);
        }
    }
}
