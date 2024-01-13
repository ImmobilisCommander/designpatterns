using Julien.Pattern.Mediator;

using Microsoft.Extensions.DependencyInjection;

namespace Julien.Pattern.Tests
{
    public class MediatorTests : IClassFixture<TestsFixture>
    {
        private readonly TestsFixture context;

        public MediatorTests(TestsFixture context)
        {
            this.context = context;
        }

        [Fact]
        public void MediatorTest()
        {
            IChatRoom chatRoom = context.ServiceProvider.GetRequiredService<IChatRoom>();

            IUser bob = context.ServiceProvider.GetRequiredService<IUser>(); bob.SetName("Bob");
            IUser alice = context.ServiceProvider.GetRequiredService<IUser>(); alice.SetName("Alice");
            IUser steve = context.ServiceProvider.GetRequiredService<IUser>(); steve.SetName("Steve");

            bob.SetChatRoom(chatRoom);
            alice.SetChatRoom(chatRoom);
            steve.SetChatRoom(chatRoom);

            chatRoom.AddUser(bob);
            chatRoom.AddUser(alice);
            chatRoom.AddUser(steve);

            bob.SendMessage("Hi, everyone!");
        }
    }
}