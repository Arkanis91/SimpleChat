using System;
using System.Net;
using System.Net.Sockets;

namespace SimpleChat.Networking
{
    public class Listener : IListener
    {
        private readonly TcpListener _tcpListener;

        public event Action<TcpClient> NewClientEvent;

        public Listener(int port)
        {
            _tcpListener = new TcpListener(IPAddress.Any, port);
            _tcpListener.Start();
        }

        private void OnNewClientEvent(TcpClient tcpClient)
        {
            Action<TcpClient> handler = NewClientEvent;
            if (handler != null) handler(tcpClient);
        }

        public void ListenToClients()
        {
            TcpClient clientCom = _tcpListener.AcceptTcpClient();
            OnNewClientEvent(clientCom);
        }
    }
}
