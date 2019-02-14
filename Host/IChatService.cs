using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace Host
{
    [ServiceContract(CallbackContract = typeof(IChatClient))]
    public interface IChatService
    {
        [OperationContract(IsOneWay = true)]
        void Join(string username);
        [OperationContract(IsOneWay = true)]
        void SendMessage(string message);
    }
}
