using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class Aprovado : EstadoDeUmOrcamento
    {
        private bool descontoAplicado = false;
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
            orcamento.Valor -= orcamento.Valor * 0.02;
            descontoAplicado = true;

            }
            else
            {
                throw new Exception("Desconto ja aplicado");
            }
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
