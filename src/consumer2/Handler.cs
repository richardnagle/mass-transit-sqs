using System;
using System.Threading.Tasks;
using MassTransit;
using messages;

namespace consumer2
{
    public class Handler: IConsumer<Information>
    {
        public async Task Consume(ConsumeContext<Information> context)
        {
            await Console.Out.WriteLineAsync($"[{context.Message.Raised}] - CONSUMER2 {context.Message.Data}");
        }
    }
}