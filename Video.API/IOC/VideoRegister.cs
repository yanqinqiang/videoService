using Video.API.EventBus;
using Video.Infrastructure.Repositories;

namespace Video.API.IOC
{
    public static class VideoRegister
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddSingleton<IVideoRepository, VideoRepository>();
            services.AddSingleton<IEventBus, RabbitMqEventBus>();
            return services;
        }
    }
}
