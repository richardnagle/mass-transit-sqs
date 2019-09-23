using System;
using System.Threading.Tasks;
using MassTransit;
using messages;

namespace consumer1
{
    public class Handler: IConsumer<IMessage>
    {
        public async Task Consume(ConsumeContext<IMessage> context)
        {
            await Console.Out.WriteLineAsync($"[{context.Message.Raised}] - CONSUMER1 {context.Message.Data}");
        }
    }
}