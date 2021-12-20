﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Impostos
{
   public abstract class TamplateDeImpostoCondicional : Imposto
    {
        public TamplateDeImpostoCondicional(Imposto outroimposto) : base(outroimposto) { }
        public TamplateDeImpostoCondicional() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else 
            {
                return MinimaTaxacao(orcamento);
            }
        }
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
