using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessagingService
{
    public interface ISendMessage
    {
        void Send(string queueName, string message, string routingKey);
    }
}
