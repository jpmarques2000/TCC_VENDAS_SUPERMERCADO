using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using TCC_VENDAS_SUPERMERCADO.Models;
using TCC_VENDAS_SUPERMERCADO.Views;

namespace TCC_VENDAS_SUPERMERCADO.ViewModels
{
    public class ConsultaProdutosViewModel : BaseViewModel
    {
        public ObservableCollection<Produto> Produtos { get; set; }

        List<Produto> produtos = new List<Produto>();

        public ConsultaProdutosViewModel()
        {
            this.Produtos = new ObservableCollection<Produto>();
        }

        public List<Produto> GetProdutos()
        {
            var produtosList = new List<Produto>();

            produtosList.AddRange(new[] {
                new Produto(1,"Pacoca",1.50),
                new Produto(2,"Batata", 2.50),
                new Produto(3,"Batata", 2.50),
                new Produto(4,"Batata", 2.50),
                new Produto(5,"Batata", 2.50)
            });
            return produtosList;
        }
    }
}
