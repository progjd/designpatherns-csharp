using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public interface IDesconta
    {
        public double Desconto(Orcamento orcamento);
        IDesconta Proximo { get; set; }
    }
}
