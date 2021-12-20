using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class FiltroMaiorQue500MilReais : Filtro
    {
        public FiltroMaiorQue500MilReais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMaiorQue500MilReais() : base() { }

        public override IList<ContaTwo> Filtra(IList<ContaTwo> contatwo)
        {
            IList<ContaTwo> contasFiltradas = new List<ContaTwo>();
            foreach (ContaTwo ctwo in contatwo)
            {
                if (ctwo.Valor > 500000)
                {
                    contasFiltradas.Add(ctwo);
                }
            }
                foreach (ContaTwo ctwo in Proximo(contatwo))
                {
                    contasFiltradas.Add(ctwo);
                }
                return contasFiltradas;
        }
    }
}
