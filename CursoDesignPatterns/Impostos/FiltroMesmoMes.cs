using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
   public class FiltroMesmoMes : Filtro
    {
        public FiltroMesmoMes(Filtro outroFiltro): base(outroFiltro) { }
        public FiltroMesmoMes() : base() { }

        public override IList<ContaTwo> Filtra(IList<ContaTwo> contatwo)
        {
            IList<ContaTwo> contasFiltradas = new List<ContaTwo>();
            foreach (ContaTwo ctwo in contatwo)
            {
                if (ctwo.DataAbertura.Month == DateTime.Now.Month && ctwo.DataAbertura.Year == DateTime.Now.Year)
                {
                    contasFiltradas.Add(ctwo);
                }
            }
            foreach(ContaTwo ctwo in Proximo(contatwo))
            {
                contasFiltradas.Add(ctwo);
            }
            return contasFiltradas;
        }
    }
}
