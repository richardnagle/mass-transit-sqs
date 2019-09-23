using System;
using System.Threading.Tasks;
using MassTransit;
using messages;

namespace consumer2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Starting Consumer2....");

            var bus = BusFactory.Create((config, host) =>
            {
                config.ReceiveEndpoint(host, "consumer_2_queue", q =>
                {
                    q.Consumer(() => new Handler());
                });
            });

            await bus.StartAsync();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            await bus.StopAsync();
        }
    }
}
