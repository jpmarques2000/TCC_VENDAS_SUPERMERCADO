using System;
using System.Collections.Generic;
using System.Text;

namespace TCC_VENDAS_SUPERMERCADO.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public double preco { get; set; }
        public int codigo { get; set; }

        //Verificar futuramente se estoque continuara na classe produto
        public decimal estoque { get; set; }

        public Produto(int id, string nome, double preco)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
        }

        public string PrecoFormatado
        {
            get
            {
                return string.Format("Valor: R$ {0}", preco);
            }
        }
    }
}
