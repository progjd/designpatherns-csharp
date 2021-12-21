using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
   public class Reprovado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamento reprovados nao aplica desconto extra");
        }
        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento ja est em estado de aprovado");
        }
        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento esta aprovado, nao pode ser reprovado agora");
        }
        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }
    }
}
