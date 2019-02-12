using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteObjects
{
    public class Message : MarshalByRefObject 
    {
        public string Sender { get; set; }

        public void SendMessage(string message,string name)
        {
            Console.WriteLine("{0}:{1}",name,message);
        }
    }
}
