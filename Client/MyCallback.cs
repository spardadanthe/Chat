using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    public class MyCallback : ChatService.IChatServiceCallback
    {
        public void ReceiveMessage(string user, string message)
        {
            Console.WriteLine("{0}:{1}",user,message);
        }
    }
}
