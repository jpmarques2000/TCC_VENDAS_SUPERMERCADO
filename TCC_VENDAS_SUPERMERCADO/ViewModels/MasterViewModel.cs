using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TCC_VENDAS_SUPERMERCADO.Models;
using Xamarin.Forms;

namespace TCC_VENDAS_SUPERMERCADO.ViewModels
{
    public class MasterViewModel : BaseViewModel
    {
        private readonly Usuario usuario;
        private ICommand EditarPerfilCommand { get; set; }

        public MasterViewModel(Usuario usuario)
        {
            this.usuario = usuario;
            DefinirComandos(usuario);
        }

        private void DefinirComandos(Usuario usuario)
        {
            EditarPerfilCommand = new Command(() =>
            {
                MessagingCenter.Send<Usuario>(usuario, "EditarPerfil");
            });
        }
    }
}
