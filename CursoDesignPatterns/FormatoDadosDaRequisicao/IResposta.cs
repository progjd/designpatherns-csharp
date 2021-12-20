using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.FormatoDadosDaRequisicao
{
    interface IResposta
    {
        void Responde(Requisicao req, ContaTwo contatwo);
       //IResposta OutraResposta { get; set; }
    }
}
