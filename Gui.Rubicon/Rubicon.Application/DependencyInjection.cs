using FluentValidation;

using Microsoft.Extensions.DependencyInjection;

namespace Rubicon.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var currentAssembly = typeof(DependencyInjection).Assembly;

            services.AddMediatR(config => config.RegisterServicesFromAssembly(currentAssembly));

            services.AddValidatorsFromAssembly(currentAssembly);

            return services;
        }
    }
}
