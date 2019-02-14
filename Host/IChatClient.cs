using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Host
{
    [ServiceContract]
    public interface IChatClient
    {
        [OperationContract(IsOneWay = true) ]
        void ReceiveMessage(string user, string message);
    }
}
