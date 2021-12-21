using CursoDesignPatterns.Impostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CursoDesignPatterns.FormatoDadosDaRequisicao
{
   public class ContaTwo
    {
        

        public DateTime DataAbertura { get; set; }
        public EstadoDaConta Estado;
        public String nameTitular { get; set; }
        public int Agencia { get; set; }
        public double Numero { get; set; }
        public double Valor { get; set; }
        public double Saldo { get; set; }

        public ContaTwo(String nametitular, int agencia, double numero, double valor, double saldo, DateTime dataabertura )
        {
            this.DataAbertura = DataAbertura;
            this.nameTitular = nametitular;
            this.Agencia = agencia;
            this.Numero = numero;
            this.Valor = valor;
            this.Saldo += valor;
        }
        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }
        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }
       

    }
}
