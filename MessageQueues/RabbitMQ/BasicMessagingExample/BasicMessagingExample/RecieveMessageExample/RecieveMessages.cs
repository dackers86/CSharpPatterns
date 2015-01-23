using Ninject;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RecieveMessageExample
{
    public class RecieveMessages
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting");
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var _connection = kernel.Get<IConnection>();
            var message = "Test Key";

            using (var channel = _connection.CreateModel())
            {
                channel.QueueDeclare(message, false, false, false, null);
                var consumer = new QueueingBasicConsumer(channel);
                channel.BasicConsume(message, true, consumer);

                while (true)
                {
                    var ea = (BasicDeliverEventArgs)consumer.Queue.Dequeue();
                    var body = ea.Body;
                    Console.WriteLine(" [x] Received {0}", Encoding.UTF8.GetString(body));
                }
            }
        }  
    }
}
