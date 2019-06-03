using Domain;
using Microsoft.Extensions.DependencyInjection;

namespace Repository
{
    public static class ServicesConfiguration
    {
        public static IServiceCollection AddMessageRepository(this IServiceCollection services)
        {
            services.AddSingleton<IRepository<Message.Message>, MessageRepository>();
            services.AddSingleton<HarbingerContext>();
            return services;
        }
    }
}