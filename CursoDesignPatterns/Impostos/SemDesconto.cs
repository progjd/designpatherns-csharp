using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class SemDesconto : IDesconta
    {
        public IDesconta Proximo { get; set; }
        public double Desconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}
