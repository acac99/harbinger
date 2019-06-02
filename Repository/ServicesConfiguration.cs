using Microsoft.Extensions.DependencyInjection;

namespace Repository
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddMessageRepository(this IServiceCollection services)
        {
            services.AddSingleton<IRepository<MessageDto>, MessageRepository>();
            return services;
        }
    }
}