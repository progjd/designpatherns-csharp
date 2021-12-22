using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
   public class ItemDaNotaBuilder
    {
        public string DescricaoDaNota { get; private set; }
        public double Valor { get; private set; }

        public ItemDaNota Constroi()
        {
            return new ItemDaNota(DescricaoDaNota, Valor);
        }

        public ItemDaNotaBuilder ComDescricao(string descricaodanota)
        {
            this.DescricaoDaNota = descricaodanota;
            return this;
        }
        public ItemDaNotaBuilder ComValor(double valor)
        {
            this.Valor = valor;
            return this;
        }
       
    }
}
