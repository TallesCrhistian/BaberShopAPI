using BaberShopAPI.Application.Interfaces;
using BaberShopAPI.Application.Services;
using BaberShopAPI.Business;
using BaberShopAPI.Business.Interfaces;
using BaberShopAPI.Data;
using BaberShopAPI.Data.Interfaces;
using BaberShopAPI.Data.Repository;
using BaberShopAPI.Data.WorkUnit;
using BaberShopAPI.Data.WorkUnit.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BaberShopAPI.API
{
    public static class ServiceExtensions
    {

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration iConfiguration)
        {
            services.AddDbContext<AppDbContext>(x => x.UseNpgsql(iConfiguration.GetConnectionString("DefaultConnection"))
                .EnableSensitiveDataLogging()
        .LogTo(Console.WriteLine, LogLevel.Information));

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IClientServices, ClientServices>();

            return services;
        }

        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddScoped<IClientBusiness, ClienteBusiness>();

            return services;
        }

        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();

            return services;
        }

        public static IServiceCollection WorkUnit(this IServiceCollection services)
        {
            services.AddScoped<IWorkUnit, WorkUnit>();
            return services;
        }
    }
}
