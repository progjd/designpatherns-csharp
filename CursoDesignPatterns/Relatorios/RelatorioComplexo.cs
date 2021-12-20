using CursoDesignPatterns.FormatoDadosDaRequisicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Relatorios
{
    class RelatorioComplexo : TamplateRelatorioCondicional
    {
        protected override void Header()
        {
            Console.WriteLine("Banco YYY");
            Console.WriteLine("AV. sss");
            Console.WriteLine("Cel: dddnnn");
        }

        protected override void Footer()
        {
            Console.WriteLine("gmail.com");
            Console.WriteLine(DateTime.Today);
        }

        protected override void Body(IList<ContaTwo> contatwo)
        {
            foreach (ContaTwo cc in contatwo)
            {
                Console.WriteLine(cc.nameTitular + "-" + cc.Agencia + "-" + cc.Numero + "-" + cc.Saldo);
            }
        }
    }
}
