using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class MasterDetailView : MasterDetailPage
    {
        private readonly Usuario usuario;

        public ObservableCollection<ProdutoItemViewModel> Produtos { get; set; }

        private NetService netService;


        private FirebaseService firebaseService;
        public MasterDetailView(Usuario usuario)
        {
            InitializeComponent();
            firebaseService = new FirebaseService();
            Produtos = new ObservableCollection<ProdutoItemViewModel>();
            netService = new NetService();
            this.usuario = usuario;
            this.Master = new MasterView(usuario);
            this.Detail = new NavigationPage(new ConsultaProdutosView(usuario));
             carregarProdutos();
           // popularProdutos();
        }

        //private void popularProdutos()
        //{
            
        //}

        private async void carregarProdutos()
        {
            var produtos = new List<Produto>();
            // if (netService.IsConnected())
            //{
                produtos = await firebaseService.GetProdutos();
            //}
            //else
            //{
                
            //}

            recarregarProdutos(produtos);
        }

        private void recarregarProdutos(List<Produto> produtos)
        {
            Produtos.Clear();

            foreach (var produto in produtos.OrderBy(p =>p.Nome))
            {
                Produtos.Add(new ProdutoItemViewModel
                    {
                        Produtoid = produto.Produtoid,
                        Nome = produto.Nome,
                        Preco = produto.Preco,                      
                        Promocao = produto.Promocao,
                        Precopromocao = produto.Precopromocao,
                        Estoque = produto.Estoque

                    });
                    
                    
            }
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            AssinarMensagens();
        }
        private void AssinarMensagens()
        {
            MessagingCenter.Subscribe<Usuario>(this, "EditarPerfil",
                (usuario) =>
                {
                    this.Detail = new NavigationPage(
                        new PerfilUsuarioView(usuario));
                    this.IsPresented = false;
                });

            MessagingCenter.Subscribe<Usuario>(this, "MeusPedidos",
                (usuario) =>
                {
                    this.Detail = new NavigationPage(
                        new MeusPedidosView());
                      this.IsPresented = false;
                });

            MessagingCenter.Subscribe<Usuario>(this, "MeuCarrinho",
                (usuario) =>
                {
                    this.Detail = new NavigationPage(
                        new CarrinhoView());
                    this.IsPresented = false;
                });

            MessagingCenter.Subscribe<Usuario>(this, "ListaProdutos",
                (usuario) =>
                {
                    this.Detail = new NavigationPage(
                        new ConsultaProdutosView(usuario));
                    this.IsPresented = false;
                });

        }

        private void CancelarAssinaturas()
        {
            MessagingCenter.Unsubscribe<Usuario>(this, "EditarPerfil");
            MessagingCenter.Unsubscribe<Usuario>(this, "MeusPedidos");
            MessagingCenter.Unsubscribe<Usuario>(this, "MeuCarrinho");
            MessagingCenter.Unsubscribe<Usuario>(this, "ListaProdutos");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CancelarAssinaturas();
        }
    }
}