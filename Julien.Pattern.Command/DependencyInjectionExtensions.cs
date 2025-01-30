using Microsoft.Extensions.DependencyInjection;

namespace Julien.Pattern.Command
{
    public static class DependencyInjectionExtensions
    { 
        public static IServiceCollection AddCommand(this IServiceCollection services)
        {
            services.AddSingleton<Light>();
            services.AddTransient<ICommand, LightOffCommand>();
            services.AddTransient<ICommand, LightOnCommand>();
            services.AddTransient<RemoteControl>();

            return services;
        }
    }
}