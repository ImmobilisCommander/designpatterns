using Julien.Pattern.BulkHead;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Serilog;

namespace Julien.Pattern.App
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            services.AddLogging((b) =>
            {
                b.ClearProviders();

                var logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.Console()
                    .CreateLogger();

                b.AddSerilog(logger);
            });

            services.AddBulkHead();

            IServiceProvider serviceProvider = services.BuildServiceProvider();

            IAnyKindOfService service = serviceProvider.GetRequiredService<IAnyKindOfService>();

            await service.DoWorkWithPollyAsync();

            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
    }
}
