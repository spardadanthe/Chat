using RemoteObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpClientChannel channel = new TcpClientChannel();

            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownClientType(
                typeof(Message), "tcp://localhost:1234/Message");

            string name = Console.ReadLine();

            Message message = new Message();
            

            while (true)
            {
                string input = Console.ReadLine();
                message.Sender = name;
                message.SendMessage(input,message.Sender);
            }
        }
    }
}
