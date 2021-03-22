using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCC_VENDAS_SUPERMERCADO.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TCC_VENDAS_SUPERMERCADO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaProdutosView : ContentPage
    {
        private Usuario _usuario;
        public ConsultaProdutosView(Usuario usuario)
        {
            
            InitializeComponent();
            _usuario = usuario;

            List<String> produtos = new List<string>()
            {
                "PRODUTO01","PRODUTO02","PRODUTO03","PRODUTO04","PRODUTO05"
            };
            lv1.ItemsSource = produtos;
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            MessagingCenter.Send<Usuario>(_usuario, "MeuCarrinho");
        }
    }
}