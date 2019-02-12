using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteObjects
{
    public class Message
    {
        public string Sender { get; set; }

        public string SendMessage(string message)
        {
            return message;
        }
    }
}
