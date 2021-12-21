using System;
using CursoDesignPatterns.CriacaoObjetosBuilder;
using CursoDesignPatterns.FormatoDadosDaRequisicao;

namespace CursoDesignPatterns.Impostos
{
    class Program
    {
      
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();
            criador.ParaEmpresa("casadacasa");
            criador.ComCnpj("23.345.345/0001-55");
            criador.ComItem(new ItemDaNota("item 1", 30));
            criador.ComItem(new ItemDaNota("item 2", 20));
            criador.DataAtual();
            criador.ComObservacoes("observando");
            NotaFiscal nf = criador.Constroi();
            Console.WriteLine(nf.ValorTotal);
            Console.WriteLine(nf.Impostos);
            Console.ReadKey();
        }
    }
}
