using Discount.Grpc.Repositories.Interfaces;
using Discount.Grpc.Repositories.Repositories;

namespace Discount.Grpc.Services
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
