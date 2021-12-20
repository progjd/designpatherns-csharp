using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    class IHIT : TamplateDeImpostoCondicional
    {
      
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
        IList<String> onOrcamento = new List<String>();
            foreach (Item item in orcamento.Itens)
            {
                if (onOrcamento.Contains(item.Name))
                    return true;
                else
                   onOrcamento.Add(item.Name);
                            
            }
            return false;
        }
        //method
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        //method two
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
