using System;
using System.Threading.Tasks;
using MassTransit;
using messages;

namespace consumer1
{
    class Program
    {
        static async Task Main(string[] args)
                 {
                     Console.ForegroundColor = ConsoleColor.Cyan;
                     Console.WriteLine("Starting Consumer1....");

                     var bus = BusFactory.Create((config, host) =>
                     {
                         config.ReceiveEndpoint(host, "consumer_1_queue", q =>
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
