using Microsoft.Extensions.DependencyInjection;

namespace Rubicon.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            var currentAssembly = typeof(DependencyInjection).Assembly;


            return services;
        }
    }
}
