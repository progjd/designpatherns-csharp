using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        private DateTime Data { get; set; }
        public string Observacoes { get; private set; }
        private double valorBruto;
        private double impostos;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
                
            
        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutada;
        
        public NotaFiscalBuilder(IList<IAcaoAposGerarNota> lista)
        {
            this.todasAcoesASeremExecutada = lista;
        }
       


        public NotaFiscal Constroi()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, Cnpj, Data, valorBruto, impostos, todosItens, Observacoes);
            foreach (IAcaoAposGerarNota acao in todasAcoesASeremExecutada)
            {
                acao.Executa(nf);
            }

            return nf;
        }
        public void AdicionarAcao(IAcaoAposGerarNota novaacao)
        {
            this.todasAcoesASeremExecutada.Add(novaacao);
        }
        

        public NotaFiscalBuilder ParaEmpresa(string razaosocial)
        {
            this.RazaoSocial = razaosocial;
            return this;
           
        }
        public NotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorBruto += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }
        public NotaFiscalBuilder ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
        public NotaFiscalBuilder NaData(DateTime novadata)
        {
            this.Data = novadata;
            return this;
            
        }
       
    }
}
