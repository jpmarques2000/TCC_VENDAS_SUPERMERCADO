using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace TCC_VENDAS_SUPERMERCADO.ViewModels
{
    public class LoginViewModel
    {
        public ICommand EntrarCommand { get; private set; }

        public LoginViewModel()
        {
            EntrarCommand = new Command(() =>
            {
                //    MainPage = new MasterDetailView();
            });
        }
    }
}
