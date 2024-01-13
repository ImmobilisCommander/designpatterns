using Castle.DynamicProxy;

using Julien.Pattern.AspectOrientedProgramming;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using Xunit.Categories;

namespace Julien.Pattern.Tests
{
    [UnitTest]
    public class AspectOrientedProgrammingTests : IClassFixture<TestsFixture>
    {
        private readonly TestsFixture context;

        public AspectOrientedProgrammingTests(TestsFixture context)
        {
            this.context = context;
        }

        [Fact]
        public void LoggingAspectTest()
        {
            MonService monService = new(context.ServiceProvider.GetRequiredService<ILogger<MonService>>());
            IInterceptor interceptor = new LoggingAspect(typeof(MonService));
            ProxyGenerator proxyGenerator = new();
            var proxy = proxyGenerator.CreateInterfaceProxyWithTarget<IMonService>(monService, interceptor);
            proxy.MaMethode();
        }
    }
}