using RabbitMQ.Client;
using SendMessagingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessagingService
{
    public class SendMessageService : ISendMessage
    {
        private readonly IConnection _connection;

        public SendMessageService(IConnection connection)
        {
            _connection = connection;
        }

        public void Send(string queueName, string message, string routingKey)
        {
            using (var channel = _connection.CreateModel())
            {
                channel.QueueDeclare(queueName, false, false, false, null);
                var body = Encoding.UTF8.GetBytes(message);
                channel.BasicPublish(string.Empty, routingKey, null, body);
            }
        }
    }
}
