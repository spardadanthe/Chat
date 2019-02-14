using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ChatService));
            host.Open();
            Console.WriteLine("Service is running");
            Console.ReadLine();
            host.Close(); ;
        }
    }
}
