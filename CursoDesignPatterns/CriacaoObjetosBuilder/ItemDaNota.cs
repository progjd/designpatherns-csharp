using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
    public class ItemDaNota
    {
        public string Name { get; set; }
        public double Valor { get; set; }

        public ItemDaNota(string name, double valor)
        {
            this.Name = name;
            this.Valor = valor;
        }
    }
}
