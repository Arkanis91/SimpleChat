using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.Networking;

namespace SimpleChat.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var listener = new Listener(8888);
            listener.NewClientEvent += ListenerOnNewClientEvent;

            while (true)
            {
                listener.ListenToClients();
            }
        }

        private static void ListenerOnNewClientEvent(TcpClient tcpClient)
        {
            Task.Factory.StartNew(() => HandleClient(tcpClient));
        }

        private static void HandleClient(TcpClient tcpClient)
        {
            var clientStream = tcpClient.GetStream();

            var message = new byte[4096];

            while (true)
            {
                int bytesRead = 0;

                try
                {
                    bytesRead = clientStream.Read(message, 0, 4096);
                }

                catch (Exception)
                {
                    // error happened
                    break;
                }

                if (bytesRead == 0)
                {
                    // client diconnected to server
                    Console.WriteLine("Client has disconnected from the server.");
                    break;
                }

                //msg has been successfully received
                var asciiEncoder = new ASCIIEncoding();
                // output msg
                Console.WriteLine(tcpClient.Client.LocalEndPoint + "\t" + tcpClient.Client.RemoteEndPoint +"\t" + asciiEncoder.GetString(message, 0, bytesRead));
                //System.Diagnostics.Debug.WriteLine(asciiEncoder.GetString(message, 0, bytesRead));
            }
            // (button)
            tcpClient.Close();
        }
    }
}
