using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Relatorios
{
    class RelatorioSimples : TamplateRelatorioCondicional
    {
        protected override void Header()
        {
            Console.WriteLine("Banco BB");
        }

        protected override void Footer()
        {
            Console.WriteLine("Cel: (19)994102710");
        }

        protected override void Body(IList<ContaTwo> contas)
        {
            foreach (ContaTwo cc in contas)
            {
                Console.WriteLine(cc.nameTitular + "-" + cc.Saldo);
            }
        }
    }
}
