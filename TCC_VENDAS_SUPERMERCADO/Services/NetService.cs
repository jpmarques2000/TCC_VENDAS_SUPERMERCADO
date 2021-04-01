using System;
using System.Collections.Generic;
using System.Text;
using TCC_VENDAS_SUPERMERCADO.Interfaces;
using Xamarin.Forms;

namespace TCC_VENDAS_SUPERMERCADO.Services
{
    public class NetService
    {
        public bool IsConnected()
        {
            var networkConnection = DependencyService.Get<INetworkConnection>();
            networkConnection.CheckNetworkConnection();
            return networkConnection.IsConnected;
        }


    }
}
