using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
   public class MultiplicadoPorNota : IAcaoAposGerarNota
    {
        public double Fator { get; set; }
        public MultiplicadoPorNota ( double fator)
        {
            this.Fator = fator;
            
        }
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine(nf.ValorTotal * this.Fator);
        }
    }
}
