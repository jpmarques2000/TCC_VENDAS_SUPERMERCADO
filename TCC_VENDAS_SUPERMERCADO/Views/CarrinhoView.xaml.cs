using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_VENDAS_SUPERMERCADO.Models;
using TCC_VENDAS_SUPERMERCADO.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TCC_VENDAS_SUPERMERCADO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarrinhoView : ContentPage
    {
        public CarrinhoViewModel ViewModel { get; set; }
        public CarrinhoView()
        {
            InitializeComponent();
            this.ViewModel = new CarrinhoViewModel();
            this.BindingContext = this.ViewModel;
            listViewPedido.ItemsSource = pedidos;
        }

        List<Pedidos> pedidos = new List<Pedidos>();

        public void carregaProdutos(List<Pedidos> listProdutos)
        {
            pedidos = listProdutos;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}