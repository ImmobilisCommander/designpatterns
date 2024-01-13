using Julien.Pattern.Bridge;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using NSubstitute;

using Xunit.Categories;

namespace Julien.Pattern.Tests
{
    [UnitTest]
    public class BridgeTests : IClassFixture<TestsFixture>
    {
        private readonly TestsFixture context;

        public BridgeTests(TestsFixture context)
        {
            this.context = context;
        }

        [Fact]
        public void BridgeTest()
        {
            var logger1 = Substitute.For<ILogger<DrawCircleWithPen>>();
            Circle redCircle = new (100, 100, 10, new DrawCircleWithPen(logger1));
            redCircle.Draw();

            var logger2 = Substitute.For<ILogger<DrawCircleWithBrush>>();
            Circle greenCircle = new (200, 200, 20, new DrawCircleWithBrush(logger2));
            greenCircle.Draw();

            logger1.Received().LogInformation("Drawing Circle [Pen] at (100, 100), radius 10");
            logger2.Received().LogInformation("Drawing Circle [Brush] at (200, 200), radius 20");
        }
    }
}