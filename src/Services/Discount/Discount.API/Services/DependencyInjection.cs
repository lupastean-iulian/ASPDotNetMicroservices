using Discount.API.Repositories.Interfaces;
using Discount.API.Repositories.Repositories;

namespace Discount.API.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDiscountRepository, DiscountRepository>();

            return services;
        }
    }
}
