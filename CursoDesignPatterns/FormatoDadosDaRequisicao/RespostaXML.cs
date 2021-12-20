using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.FormatoDadosDaRequisicao
{
    class RespostaXML : IResposta
    {
        public IResposta OutraResposta { get; set; }

        //constructor
        public RespostaXML(IResposta outraresposta)
        {
            this.OutraResposta = outraresposta;
        }
        public RespostaXML()
        {
            this.OutraResposta = null;
        }
        public void Responde(Requisicao req, ContaTwo contatwo)
        {
            if (req.Formato == Formato.XML)
            {
                Console.WriteLine("<conta><nameTitular>" + contatwo.nameTitular + "<nameTitular><saldo>" + contatwo.Saldo + "<saldo><conta>");
            }
            else if(OutraResposta !=null)
            {
                OutraResposta.Responde(req, contatwo);
            }
            else
            {
                throw new Exception("Outra Resposta nao encontrada");
            }
        }

    }
}
