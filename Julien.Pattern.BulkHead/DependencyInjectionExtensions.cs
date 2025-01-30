using Microsoft.Extensions.DependencyInjection;

namespace Julien.Pattern.BulkHead
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddBulkHead(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseService, DatabaseService>();
            services.AddScoped<IAnyKindOfService, AnyKindOfService>();

            return services;
        }
    }
}