using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_VENDAS_SUPERMERCADO.Models;
using TCC_VENDAS_SUPERMERCADO.Services;
using TCC_VENDAS_SUPERMERCADO.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TCC_VENDAS_SUPERMERCADO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaProdutosView : ContentPage
    {

        private FirebaseService firebaseService = new FirebaseService();
        public ConsultaProdutosViewModel ViewModel { get; set; }

        private Usuario _usuario;
        public ConsultaProdutosView(Usuario usuario)
        {
            
            InitializeComponent();
            _usuario = usuario;
            this.ViewModel = new ConsultaProdutosViewModel();
            this.BindingContext = this.ViewModel;
            //listViewProdutos.ItemsSource = this.ViewModel.GetProdutos();

            //List<String> produtos = new List<string>()
            //{
            //    "PRODUTO01","PRODUTO02","PRODUTO03","PRODUTO04","PRODUTO05"
            //};
            //lv1.ItemsSource = produtos;
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            MessagingCenter.Send<Usuario>(_usuario, "MeuCarrinho");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        //private async void btnIncluir_Clicked(object sender, EventArgs e)
        //{
        //    await firebaseService.AddProduto(Convert.ToInt32(txtProdutoId.Text), txtNome.Text, Convert.ToDouble(txtPreco.Text), Convert.ToBoolean(txtPromocao.Text),
        //        Convert.ToDouble(txtPrecopromocao.Text), Convert.ToDecimal(txtEstoque.Text));

        //    txtProdutoId.Text = string.Empty;
        //    txtNome.Text = string.Empty;
        //    txtPreco.Text = string.Empty;
        //    txtPromocao.Text = string.Empty;
        //    txtPrecopromocao.Text = string.Empty;
        //    txtEstoque.Text = string.Empty;

        //    await DisplayAlert("Successo", "Produto incluído com sucesso", "OK");

        //    var produtos = await firebaseService.GetProdutos();
            
        //}
    }
}