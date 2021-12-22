using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
    public class NotaFiscal
    {
        public String RazaoSocial { get; set; }
        public String Cnpj { get; set; }
        public DateTime DataEmissao { get; set; }
        public String Observacoes { get; set; }
        public double ValorTotal { get; set; }
        public double Impostos { get; set; }
        public IList<ItemDaNota> todosItens{ get; set; }

        public NotaFiscal (String razaosocial, String cnpj, DateTime dataemissao,
            double valorbruto, double impostos, IList<ItemDaNota> itens, String observacoes)
        {
            this.RazaoSocial = razaosocial;
            this.Cnpj = cnpj;
            this.DataEmissao = dataemissao;
            this.ValorTotal = valorbruto;
            this.Impostos = impostos;
            this.todosItens = itens;
            this.Observacoes = observacoes;
            
        }
    }
}
