using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SimpleChat.Core.Objects.Client
{
    public class ClientUser
    {
        public TcpClient TcpClient { get; set; }

        public int Id { get; set; }

        public string Username { get; set; }
    }
}
