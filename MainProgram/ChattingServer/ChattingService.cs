using ChattingInterfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChattingServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ChattingService" in both code and config file together.
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.Single)]

    public class ChattingService : IChattingService
    {
        public ConcurrentDictionary<string, ConnectedClient> _connectedClients = new ConcurrentDictionary<string, 
            ConnectedClient>();

        public int Login(string userName)
        {
            //Checks for login to make sure no one else can login with the same name
            foreach(var client in _connectedClients)
            {
                if(client.Key.ToLower() == userName.ToLower())
                {

                    return 1;
                }

            }

            var establishedUserConnection = OperationContext.Current.GetCallbackChannel<IClient>();

            ConnectedClient newClient = new ConnectedClient();
            newClient.connection = establishedUserConnection;
            newClient.UserName = userName;

            
            _connectedClients.TryAdd(userName, newClient);

            return 0;
        }

        public void SendMessageToAll(string message, string userName)
        {
            foreach (var client in _connectedClients)
            {
                if (client.Key.ToLower() != userName.ToLower())
                {
                    client.Value.connection.GetMessage(message, userName);
                }
            }
        }
    }
}
