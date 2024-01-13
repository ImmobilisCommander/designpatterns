using Microsoft.Extensions.DependencyInjection;

namespace Julien.Pattern.Visitor
{
    public static class Ext
    {
        public static IServiceCollection AddVisitor(this IServiceCollection services)
        {
            services.AddTransient<IVisitable, ConcreteVisitable>(sp => { return new ConcreteVisitable { Property = "Hello" }; });
            services.AddTransient<IVisitor, ConcreteVisitor>();

            return services;
        }
    }
}