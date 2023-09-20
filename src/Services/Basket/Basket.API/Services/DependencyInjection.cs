using Basket.API.GrpcServices;
using Basket.API.Repositories.Interfaces;
using Basket.API.Repositories.Repositories;

namespace Basket.API.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services)
        {
            services.AddScoped<IBasketRepository, BasketRepository>();

            return services;
        }
    }
}
