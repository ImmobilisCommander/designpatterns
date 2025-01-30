using Julien.Pattern.BulkHead;
using Julien.Pattern.Command;
using Julien.Pattern.Mediator;
using Julien.Pattern.Visitor;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Serilog;

namespace Julien.Pattern.Tests
{
    public class TestsFixture
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public TestsFixture()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddLogging((b) =>
            {
                b.ClearProviders();

                var logger = new LoggerConfiguration()
                    .MinimumLevel.Debug()
                    .WriteTo.Debug()
                    .CreateLogger();

                b.AddSerilog(logger);
            });

            services.AddCommand();
            services.AddMediator();
            services.AddVisitor();
            services.AddBulkHead();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}