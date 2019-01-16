using Business;
using Business.Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetGroup.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureMySqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["mysqlconnection:connectionString"];
            services.AddDbContext<RepositoryContext>(o => o.UseMySql(connectionString));
        }

        public static void ConfigureBusiness(this IServiceCollection services)
        {
            services.AddTransient<IUserBusiness, UserBusiness>();
        }

        public static void ConfigureRepository(this IServiceCollection services)
        {
            services.AddTransient<IRepositoryBase<User>, RepositoryBase<User>>();
            services.AddTransient<IUserRepository, UserRepository>();
        }
    }
}
