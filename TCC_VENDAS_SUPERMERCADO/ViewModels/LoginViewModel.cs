﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TCC_VENDAS_SUPERMERCADO.Models;
using Xamarin.Forms;

namespace TCC_VENDAS_SUPERMERCADO.ViewModels
{
    public class LoginViewModel
    {
        private string usuario;
        public string Usuario
        {
            get { return usuario; }
            set
            {
                usuario = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
                ((Command)EntrarCommand).ChangeCanExecute();
            }
        }
        public ICommand EntrarCommand { get; private set; }

        public LoginViewModel()
        {
            EntrarCommand = new Command(async() =>
            {
                var loginService = new LoginService();
                await loginService.FazerLogin(new Login(usuario, senha));
                //    MainPage = new MasterDetailView();
            });
        }
    }
}
