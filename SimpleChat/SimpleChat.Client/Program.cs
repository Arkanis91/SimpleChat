using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SimpleChat.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client");
            Thread.Sleep(2000);

            var client = new TcpClient();

            var serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);

            client.Connect(serverEndPoint);

            var clientStream = client.GetStream();

            for (int i = 0; i < 2; i++)
            {
                var message = Console.ReadLine() ?? "";

                var encoder = new ASCIIEncoding();
                var buffer = encoder.GetBytes(message);

                clientStream.Write(buffer, 0, buffer.Length);
                clientStream.Flush();
            }

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

    }
}
