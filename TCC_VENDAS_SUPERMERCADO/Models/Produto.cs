using System;
using System.Collections.Generic;
using System.Text;

namespace TCC_VENDAS_SUPERMERCADO.Models
{
    public class Produto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public decimal preco { get; set; }

        //Verificar futuramente se estoque continuara na classe produto
        public decimal estoque { get; set; }
    }
}
