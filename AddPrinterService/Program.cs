using System;
using System.Threading;
using System.Threading.Tasks;
using Topshelf;

namespace AddPrinterServiceBus
{
    class Program
    {
        static async Task Main(string[] args)
        {
            QueueServiceReceiver queueServiceReceiver = new QueueServiceReceiver();

            await queueServiceReceiver.ReceiveMessageAsync();
        }
    }
}
