using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.FormatoDadosDaRequisicao
{
    class RespostaCSV : IResposta
    {
        public IResposta OutraResposta { get; set; }
        
        //constructor
        public RespostaCSV(IResposta outraresposta)
        {
            this.OutraResposta = outraresposta;
        }
        public RespostaCSV()
        {
            this.OutraResposta = null;
        }
        public void Responde(Requisicao req, ContaTwo contatwo)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(contatwo.nameTitular + ";" + contatwo.Saldo);
            }
            else if(OutraResposta != null)
            {
                OutraResposta.Responde(req, contatwo);
            }
            else
            {
                throw new Exception("Outro formato de resposta nao encontrado");
            }
        }
    }
}
