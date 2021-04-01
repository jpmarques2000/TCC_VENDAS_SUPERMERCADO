using System;
using System.Collections.Generic;
using System.Text;

namespace TCC_VENDAS_SUPERMERCADO.Models
{
    public class Produto
    {
        public int Produtoid { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public bool Promocao { get; set; }

        public double Precopromocao { get; set; }

        //Verificar futuramente se estoque continuara na classe produto
        public decimal Estoque { get; set; }

        ////public Produto(int Produtoid, string Nome, double Preco, int Codigo, bool Promocao, double Precopromocao, decimal Estoque)
        ////{
        ////    this.Produtoid = Produtoid;
        ////    this.Nome = Nome;
        ////    this.Preco = Preco;
        ////    this.Codigo = Codigo;
        ////    this.Promocao = Promocao;
        ////    this.Precopromocao = Precopromocao;
        ////    this.Estoque = Estoque;
        ////}

       

        public string PrecoFormatado
        {
            get
            {
                return string.Format("Valor: R$ {0}", Preco);
            }
        }
    }
}
