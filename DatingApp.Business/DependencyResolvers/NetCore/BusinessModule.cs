using DatingApp.Business.Abstract;
using DatingApp.Business.Concrete.Managers;
using DatingApp.DataAccess.Abstract;
using DatingApp.DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace DatingApp.Business.DependencyResolvers.NetCore
{
    public static class BusinessModule
    {
        public static IServiceCollection BusinessServicess(this IServiceCollection services)
        {
            services.AddDbContext<DataContext>();
            services.AddScoped<IValueService,ValueManager>();
            services.AddScoped<IValueDal,EfValueDal>();

            return services;
        }
    }
}