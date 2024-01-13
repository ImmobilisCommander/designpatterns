using Julien.Pattern.Command;

using Microsoft.Extensions.DependencyInjection;

namespace Julien.Pattern.Tests
{
    public class CommandTests : IClassFixture<TestsFixture>
    {
        private readonly TestsFixture context;

        public CommandTests(TestsFixture context)
        {
            this.context = context;
        }

        [Fact]
        public void CommandTest()
        {
            RemoteControl remoteControl = context.ServiceProvider.GetRequiredService<RemoteControl>();

            remoteControl.PressOnButton();
            remoteControl.PressOffButton();
        }
    }
}