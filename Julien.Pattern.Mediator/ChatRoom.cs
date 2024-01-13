namespace Julien.Pattern.Mediator
{
    using Microsoft.Extensions.DependencyInjection;

    using System.Collections.Generic;

    // Concrete Mediator class
    public class ChatRoom : IChatRoom
    {
        private readonly List<IUser> users = new();

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string message, IUser user)
        {
            foreach (var u in users)
            {
                if (u != user)
                {
                    u.ReceiveMessage(message);
                }
            }
        }
    }

    public static class Ext
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddSingleton<IChatRoom, ChatRoom>();
            services.AddTransient<IUser, User>();

            return services;
        }
    }

}