using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleChat.Core.Objects.Client;

namespace SimpleChat.Core.Objects
{
    public class ChatMessage
    {
        public ClientUser SenderUser { get; set; }

        public string Message { get; set; }

        public DateTime SendDateTime { get; set; }

        public DateTime ReceiveDateTime { get; set; }

    }
}
