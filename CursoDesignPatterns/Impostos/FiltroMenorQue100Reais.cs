using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class FiltroMenorQue100Reais : Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro) : base(outroFiltro) { }
        public FiltroMenorQue100Reais() : base() { }

        public override IList<ContaTwo> Filtra(IList<ContaTwo> contatwo)
        {
            IList<ContaTwo> contasfiltrada = new List<ContaTwo>();
            foreach (ContaTwo ctwo in contatwo)
            {
                if (ctwo.Valor < 100) contasfiltrada.Add(ctwo);
            }
            foreach (ContaTwo ctwo in Proximo(contatwo))
            {
                contasfiltrada.Add(ctwo);
            }
            return contasfiltrada;
        }
    }
}
