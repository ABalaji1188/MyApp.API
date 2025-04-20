using MyApp.Application;
using MyApp.Infrastrcture;

namespace MyApp.API
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
                .AddInfrastrctureDI();
            return services;
        }
    }
}
