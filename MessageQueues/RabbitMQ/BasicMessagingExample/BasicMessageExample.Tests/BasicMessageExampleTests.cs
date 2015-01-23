using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SendMessagingService;
using RabbitMQ.Client;
using Moq;
using System.Text;

namespace BasicMessageExample.Tests
{
    [TestClass]
    public class BasicMessageExampleTests
    {
        [TestMethod]
        public void WhenISendAMessage_ItShouldBeAddedToTheMessageQueue()
        {
            var message = "Hello World!";
            var body = Encoding.UTF8.GetBytes(message);
            var routingKey = "hello;";
            var queueName = "TestQueue";

            var connection = new Mock<IConnection>();
            var sendMessagingService = new SendMessageService(connection.Object);

            sendMessagingService.Send(queueName, message, routingKey);
        }
    }
}
