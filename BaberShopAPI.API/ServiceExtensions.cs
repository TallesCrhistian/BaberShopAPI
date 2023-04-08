using BaberShopAPI.Application.Interfaces;
using BaberShopAPI.Application.Services;
using BaberShopAPI.Data;
using BaberShopAPI.Data.WorkUnit;
using BaberShopAPI.Data.WorkUnit.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BaberShopAPI.API
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration iConfiguration)
        {
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(iConfiguration.GetConnectionString("DefaultConnection")));

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IClientServices, ClientServices>();
           
            return services;
        }

        //public static IServiceCollection AddBusiness(this IServiceCollection services)
        //{
        //    services.AddScoped<IClienteNegocios, ClienteNegocios>();
           
        //    return services;
        //}

        //public static IServiceCollection AddRepository(this IServiceCollection services)
        //{
        //    services.AddScoped<IClienteRepositorio, ClienteRepositorio>();
           
        //    return services;
        //}

        public static IServiceCollection WorkUnit(this IServiceCollection services)
        {
            services.AddScoped<IWorkUnit, WorkUnit>();
            return services;
        }
    }
}
