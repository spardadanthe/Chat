using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpServerChannel channel = new TcpServerChannel(1234);

            ChannelServices.RegisterChannel(channel, false);

            RemotingConfiguration.RegisterWellKnownServiceType
                (typeof(RemoteObjects.Message), "Message",
                WellKnownObjectMode.Singleton);

            Console.WriteLine("Starting...");
            Console.ReadLine();

        }
    }
}
