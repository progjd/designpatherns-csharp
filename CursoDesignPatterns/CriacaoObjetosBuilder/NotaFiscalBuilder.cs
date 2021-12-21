using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime Data { get; private set; }
        public string Observacoes { get; private set; }
        private double valorTotal;
        private double impostos;
        public IList<ItemDaNota> todosItens = new List<ItemDaNota>();

     public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, valorTotal, impostos, todosItens, Observacoes);
        }

        public void ParaEmpresa(string razaosocial)
        {
            this.RazaoSocial = razaosocial;
           
        }
        public void ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
        }

        public void ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
        }
        public void ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
        }
        public void DataAtual()
        {
            this.Data = DateTime.Now;
        }
    }
}
