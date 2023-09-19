using Catalog.API.DAL.Interfaces;
using Catalog.API.Data.Context;
using Catalog.API.Data.Interfaces;
using Catalog.API.Repositories.Repositories;

namespace Catalog.API.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepositoryDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICatalogContext, CatalogContext>();
            services.AddScoped<IProductRepository, ProductRepository>();

            return services;
        }
    }
}
