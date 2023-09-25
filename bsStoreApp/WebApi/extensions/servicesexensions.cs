using Microsoft.EntityFrameworkCore;
using repositories.contracts;
using repositories.Efcore;
using services;
using services.contracts;

namespace WebApi.extensions
{
    public static class servicesexensions
    {
        public static void configeresqlcontext(this IServiceCollection services,IConfiguration configuration)
        =>
            services.AddDbContext<Repositorycontext>(options =>
options.UseSqlServer(configuration.GetConnectionString("sqlconnection")));

        public static void configurerepositorymanager(this IServiceCollection services) =>
            services.AddScoped<Irepositorymanager, repositorymanager>();
        public static void configurereserviceymanager(this IServiceCollection services) =>
           services.AddScoped<Iservicemanager, servicemanager>();

    }
}
