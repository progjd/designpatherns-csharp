using CursoDesignPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            IDesconta d1 = new DescontoPorCincoItens();
            IDesconta d2 = new DescontoPorMaisQuinhentos();
            IDesconta d3 = new DescontoPorVendaCasada();
            IDesconta d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            return d1.Desconto(orcamento);
           
        }

    }
}
