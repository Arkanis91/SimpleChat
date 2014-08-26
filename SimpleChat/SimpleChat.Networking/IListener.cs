using System;
using System.Net.Sockets;

namespace SimpleChat.Networking
{
    public interface IListener
    {
        event Action<TcpClient> NewClientEvent;
        void ListenToClients();
    }
}