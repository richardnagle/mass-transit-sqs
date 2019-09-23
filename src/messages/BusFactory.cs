using System;
using MassTransit;
using MassTransit.AmazonSqsTransport;
using MassTransit.AmazonSqsTransport.Configuration;

namespace messages
{
    public static class BusFactory
    {
        public static IBusControl Create() => Create((c, h) => { });

        public static IBusControl Create(Action<IAmazonSqsBusFactoryConfigurator, IAmazonSqsHost> configurator)
        {
            const string url = "eu-west-2";
            const string accessKey = 
            const string secretKey = 

            return Bus.Factory.CreateUsingAmazonSqs(cfg =>
            {
                var host = cfg.Host(url, h =>
                {
                    h.AccessKey(accessKey);
                    h.SecretKey(secretKey);
                });
                configurator(cfg, host);
            });
        }
    }
}