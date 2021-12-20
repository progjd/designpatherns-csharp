using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    class DescontoPorVendaCasada : IDesconta
    {
        public IDesconta Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
            if (vendaCasada(orcamento))
                return orcamento.Valor * 0.05;
            else
                return Proximo.Desconto(orcamento);

            bool vendaCasada(Orcamento orcamento)
            {
                return Exists("Lapis", orcamento) && Exists("Caneta", orcamento);
            }

           bool Exists(String nomeDoItem, Orcamento orcamento)
            {
                foreach (Item item in orcamento.Itens)
                {
                    if (item.Name.Equals(nomeDoItem))
                        return true;
                }
                return false;
            }
            
        }
    }
}
