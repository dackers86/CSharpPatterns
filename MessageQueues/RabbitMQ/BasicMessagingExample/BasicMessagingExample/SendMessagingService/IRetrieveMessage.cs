using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessagingService
{
    public interface IRecieveMessage
    {
        List<string> Get(string message, string routingKey);
    }
}
