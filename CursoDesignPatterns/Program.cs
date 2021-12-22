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
            
            criador.AdicionarAcao(new EnviandoPorEmail());
            criador.AdicionarAcao(new EnviandoPorSMS());
            criador.AdicionarAcao(new NotaSalvaNoDAO());
            criador.AdicionarAcao(new Impressao());
            criador.AdicionarAcao(new MultiplicadoPorNota(2));
            criador.AdicionarAcao(new MultiplicadoPorNota(3));
            NotaFiscal nf = criador.ParaEmpresa("casablanca")
            .ComCnpj("23.345.345/0001-55")
            .ComItem(new ItemDaNota("item 1", 200.0))
            .ComItem(new ItemDaNota("item 2", 250.0))
            .ComObservacoes("observando")
            .Constroi();
            Console.WriteLine(nf.ValorTotal);
            Console.WriteLine(nf.Impostos);
           


            Console.ReadKey();
        }
    }
}
