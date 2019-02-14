using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Host
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Single,InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService : IChatService
    {
        Dictionary<IChatClient, string> users = new Dictionary<IChatClient, string>();
        public void Join(string username)
        {
            var connection = OperationContext.Current.GetCallbackChannel<IChatClient>();
            users[connection] = username;
        }

        public void SendMessage(string message)
        {
            var connection = OperationContext.Current.GetCallbackChannel<IChatClient>();
            string user;
            if(!users.TryGetValue(connection,out user))
            {
                return;
            }

            foreach (var other in users.Keys)
            {
                if (other == connection)
                    continue;
                other.ReceiveMessage(user, message);
            }
        }
    }
}
