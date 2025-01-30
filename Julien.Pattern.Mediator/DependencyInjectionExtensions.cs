namespace Julien.Pattern.Mediator
{
    using Microsoft.Extensions.DependencyInjection;

    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddSingleton<IChatRoom, ChatRoom>();
            services.AddTransient<IUser, User>();

            return services;
        }
    }

}