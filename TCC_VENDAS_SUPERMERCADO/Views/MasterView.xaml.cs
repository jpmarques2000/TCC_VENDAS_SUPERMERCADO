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
    public partial class MasterView : TabbedPage
    {
        public MasterViewModel ViewModel { get; set; }
        private Usuario _usuario;
        public MasterView(Usuario usuario)
        {
            InitializeComponent();
            this.ViewModel = new MasterViewModel(usuario);
            _usuario = usuario;
        }


        private void Button_Clicked_1(object sender, EventArgs e)
        {
            MessagingCenter.Send<Usuario>(_usuario, "EditarPerfil");
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            MessagingCenter.Send<Usuario>(_usuario, "MeusPedidos");
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            MessagingCenter.Send<Usuario>(_usuario, "MeuCarrinho");
        }
    }
}