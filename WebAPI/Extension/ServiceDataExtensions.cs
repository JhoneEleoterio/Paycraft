using Microsoft.EntityFrameworkCore;
using WebAPI.Data;

namespace WebAPI.Extension
{
    public static class ServiceDataExtensions
    {
        public static IServiceCollection AddDatabaseService(
            this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<PayCraftDataContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });

            return services;
        }

    }
}
