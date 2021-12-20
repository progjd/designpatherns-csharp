using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public abstract class Filtro
    {
        protected Filtro OutroFiltro { get; set; }
        public Filtro(Filtro outroFiltro)
        {
            this.OutroFiltro = outroFiltro;
        }

        public Filtro() { }
        public abstract IList<ContaTwo> Filtra(IList<ContaTwo> contatwo);

        protected IList<ContaTwo> Proximo(IList<ContaTwo> contatwo)
        {
            if (OutroFiltro != null)
            {
                return OutroFiltro.Filtra(contatwo);
            }
                else
                {
                    return new List<ContaTwo>();
                }
        }
    }
}
