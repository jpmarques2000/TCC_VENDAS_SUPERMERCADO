using System;
using System.Collections.Generic;
using System.Text;

namespace TCC_VENDAS_SUPERMERCADO.Interfaces
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    }
}
