using System;
using System.Threading.Tasks;
using messages;

namespace producer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting Producer....");
            var bus = BusFactory.Create();
            await bus.StartAsync();
            await bus.Publish(new Information("some message data"));
            await Task.Delay(5000);
            await bus.Publish(new Alert());

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

            await bus.StopAsync();
        }
    }
}
