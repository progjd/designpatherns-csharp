using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.FormatoDadosDaRequisicao
{
        enum Formato
        {
            CSV,
            XML,
            PORCENTO
        }
        class Requisicao
    {
        public Formato Formato { get; set; }
        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }
    }
}
