using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroimposto) : base(outroimposto) { }
        public ImpostoMuitoAlto(): base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalculoDoOutroImposto(orcamento);
        }
    }
}
