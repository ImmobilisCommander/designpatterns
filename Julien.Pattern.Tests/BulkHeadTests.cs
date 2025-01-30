using Julien.Pattern.BulkHead;

using Microsoft.Extensions.DependencyInjection;

using Shouldly;

using Xunit.Abstractions;

namespace Julien.Pattern.Tests
{
    public class BulkHeadTests : IClassFixture<TestsFixture>
    {
        private readonly ITestOutputHelper testOutputHelper;
        private readonly TestsFixture fixture;

        public BulkHeadTests(ITestOutputHelper testOutputHelper, TestsFixture fixture)
        {
            this.testOutputHelper = testOutputHelper;
            this.fixture = fixture;
        }

        [Fact]
        public async Task DatabaseServiceTest()
        {
            IDatabaseService databaseService = fixture.ServiceProvider.GetRequiredService<IDatabaseService>();
            var result = await databaseService.QueryDatabaseAsync("");
            result.ShouldBe("Hello world!");
        }

        [Fact]
        public async Task AnyKindOfService_DoWorkWithActionBlockAsyncTest()
        {
            IAnyKindOfService anyKindOfService = fixture.ServiceProvider.GetRequiredService<IAnyKindOfService>();
            int result = await anyKindOfService.DoWorkWithActionBlockAsync();
            testOutputHelper.WriteLine($"{result}");
        }

        [Fact]
        public async Task AnyKindOfService_DoWorkWithFunctAsyncTest()
        {
            IAnyKindOfService anyKindOfService = fixture.ServiceProvider.GetRequiredService<IAnyKindOfService>();
            int result = await anyKindOfService.DoWorkWithFunctAsync();
            testOutputHelper.WriteLine($"{result}");
        }

        [Fact]
        public async Task AnyKindOfService_DoWorkWithPollyAsyncTest()
        {
            IAnyKindOfService anyKindOfService = fixture.ServiceProvider.GetRequiredService<IAnyKindOfService>();
            int result = await anyKindOfService.DoWorkWithPollyAsync();
            testOutputHelper.WriteLine($"{result}");
        }
    }
}