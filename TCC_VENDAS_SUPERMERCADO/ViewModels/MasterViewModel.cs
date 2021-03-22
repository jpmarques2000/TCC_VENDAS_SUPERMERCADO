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
        public string Nome
        {
            get { return this.usuario.nome; }
            set { this.usuario.nome = value; }
        }

        public string DataNascimento
        {
            get { return this.usuario.dataNascimento; }
            set { this.usuario.dataNascimento = value; }
        }

        public string Telefone
        {
            get { return this.usuario.telefone; }
            set { this.usuario.telefone = value; }
        }

        public string Email
        {
            get { return this.usuario.email; }
            set { this.usuario.email = value; }
        }

        public string Cep
        {
            get { return this.usuario.cep; }
            set { this.usuario.cep = value; }
        }

        public string Rua
        {
            get { return this.usuario.rua; }
            set { this.usuario.rua = value; }
        }

        public string Bairro
        {
            get { return this.usuario.bairro; }
            set { this.usuario.bairro = value; }
        }

        public string Numero
        {
            get { return this.usuario.numero; }
            set { this.usuario.numero = value; }
        }

        private bool editando = false;
        public bool Editando
        {
            get { return editando; }
            private set
            {
                editando = value;
                OnPropertyChanged();
            }
        }

        private readonly Usuario usuario;
        private ICommand EditarPerfilCommand { get; set; }
        private ICommand MeusPedidoCommand { get; set; }
        private ICommand MeuCarrinhoCommand { get; set; }
        public ICommand SalvarCommand { get; private set; }
        public ICommand EditarCommand { get; private set; }

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

            MeusPedidoCommand = new Command(() =>
            {
                MessagingCenter.Send<Usuario>(usuario, "MeusPedidos");
            });

            MeuCarrinhoCommand = new Command(() =>
            {
                MessagingCenter.Send<Usuario>(usuario, "MeuCarrinho");
            });

            SalvarCommand = new Command(() =>
            {
                this.Editando = false;
                MessagingCenter.Send<Usuario>(usuario, "SucessoSalvarUsuario");
            });

            EditarCommand = new Command(() =>
            {
                this.Editando = true;
            });
        }
    }
}
