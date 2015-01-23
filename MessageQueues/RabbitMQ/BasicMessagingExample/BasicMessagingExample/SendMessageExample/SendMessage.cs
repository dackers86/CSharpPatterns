using SendMessagingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;
using RabbitMQ.Client;

namespace SendMessageExample
{
    public class SendMessage
    {
        public static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var connection = kernel.Get<IConnection>();
            var sendMessageService = new SendMessageService(connection);

            while (true)
            {
                var message = Console.ReadLine();
                sendMessageService.Send("TestQueue", message, "Test Key");
            }
        }
    }
}
