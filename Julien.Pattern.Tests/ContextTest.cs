using Julien.Pattern.Command;
using Julien.Pattern.Mediator;
using Julien.Pattern.Visitor;

using Microsoft.Extensions.DependencyInjection;

using Serilog;

namespace Julien.Pattern.Tests
{
    public class TestsFixture
    {
        public IServiceProvider ServiceProvider { get; private set; }

        public TestsFixture()
        {
            ServiceCollection services = new();

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Debug()
                .CreateLogger();

            services.AddLogging((b) => { b.AddSerilog(); });

            services.AddCommand();
            services.AddMediator();
            services.AddVisitor();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}