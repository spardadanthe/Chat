using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            InstanceContext context = new InstanceContext(new MyCallback());
            ChatService.ChatServiceClient server = new ChatService.ChatServiceClient(context);

            Console.WriteLine("Enter username: ");
            string username = Console.ReadLine();
            server.Join(username);

            Console.WriteLine();
            Console.WriteLine("Enter Message");


            while (true)
            {
                var message = Console.ReadLine();

                if(!string.IsNullOrEmpty(message))
                {
                    server.SendMessage(message);
                }
            }

        }
    }
}
