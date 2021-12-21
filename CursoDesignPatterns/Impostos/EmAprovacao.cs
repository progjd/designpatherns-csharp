using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
   public class EmAprovacao : EstadoDeUmOrcamento
    {
        private bool descontoAplica = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplica)
            {
            orcamento.Valor = orcamento.Valor - (orcamento.Valor * 0.05);
                descontoAplica = true;
            }
            else
            {
                throw new Exception("Desconto ja aplicado");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Aprovado();
        }
        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Reprovado();
        }
        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento em aprovacao nao pode ir para finalizado direto");
        }
    }
}
