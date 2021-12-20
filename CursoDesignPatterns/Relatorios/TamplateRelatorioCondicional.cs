using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoDesignPatterns.Relatorios
{
    abstract class TamplateRelatorioCondicional
    {
        
        protected abstract void Header();
        protected abstract void Footer();
        protected abstract void Body(IList<ContaTwo> contatwo);

        public void Print(IList<ContaTwo> contatwo)
        {
            Header();
            Body(contatwo);
            Footer();

        }
    }
}
