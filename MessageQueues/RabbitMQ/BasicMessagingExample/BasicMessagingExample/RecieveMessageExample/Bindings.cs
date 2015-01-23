﻿using Ninject.Modules;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMessageExample
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IConnection>()
            .ToMethod(ctx =>
            {
                var factory = new ConnectionFactory { HostName = "localhost" };
                var connection = factory.CreateConnection();
                return connection;
            })
            .InSingletonScope();
        }
    }
}
