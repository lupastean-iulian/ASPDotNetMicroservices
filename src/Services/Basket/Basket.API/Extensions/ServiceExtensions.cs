namespace Basket.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRedis(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddStackExchangeRedisCache(options =>
            {
                options.Configuration = configuration.GetValue<string>("CacheSettings:ConnectionString");
            });
        }
    }
}
