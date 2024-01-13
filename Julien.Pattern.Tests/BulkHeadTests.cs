using Julien.Pattern.BulkHead;

using Shouldly;

namespace Julien.Pattern.Tests
{
    public class BulkHeadTests
    {
        [Fact]
        public async Task BulkHeadTest()
        {
            DatabaseService databaseService = new();

            var result = await databaseService.QueryDatabaseAsync("");
            result.ShouldBe("Hello world!");
        }
    }
}