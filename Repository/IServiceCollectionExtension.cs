using Microsoft.Extensions.DependencyInjection;

namespace Repository
{
    public static class IServiceCollectionExtension
    {
        public static void AddMessageRespository(this IServiceCollection services)
        {
            services.AddSingleton<IRepository<Message>, MessageRepository>();
        }
    }
}