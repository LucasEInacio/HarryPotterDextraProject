using HarryPotterProject.Data.EFConfiguration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace HarryPotterProject.CrossCutting
{
    public static class DependencyInjection
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            RegisterDataBase(services, configuration);

            RegisterDataServices(services);
        }

        private static void RegisterDataBase(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<HarryPotterContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }

        private static void RegisterDataServices(IServiceCollection services)
        {
            services.RegisterTypes(Data.IoC.Module.GetTypes());
        }

        private static void RegisterTypes(this IServiceCollection services, Dictionary<Type, Type> types)
        {
            foreach (var item in types)
            {
                services.AddTransient(item.Key, item.Value);

            }
        }
    }
}
