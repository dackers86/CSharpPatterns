using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessagingService
{
    public class RecieveMessageService : IRecieveMessage
    {
        private readonly IConnection _connection;

        public RecieveMessageService(IConnection connection)
        {
            _connection = connection;
        }

        List<string> IRecieveMessage.Get(string message, string routingKey)
        {
            throw new NotImplementedException();
        }
    }
}
