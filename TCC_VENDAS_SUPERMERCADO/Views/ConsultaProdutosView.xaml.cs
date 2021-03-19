using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TCC_VENDAS_SUPERMERCADO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConsultaProdutosView : ContentPage
    {
        public ConsultaProdutosView()
        {
            InitializeComponent();

            List<String> produtos = new List<string>()
            {
                "PRODUTO01","PRODUTO02","PRODUTO03","PRODUTO04","PRODUTO05"
            };
            lv1.ItemsSource = produtos;
            
        }
    }
}