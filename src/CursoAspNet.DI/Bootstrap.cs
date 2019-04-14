using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using CursoAspNet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using CursoAspNet.Domain;
using CursoAspNet.Domain.Items;
using CursoAspNet.Domain.Operations;
using CursoAspNet.Domain.Orders;

namespace CursoAspNet.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
              options.UseSqlServer(connectionString));
            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddSingleton(typeof(ItemStorer));
            services.AddScoped(typeof(ItemStorer));
            services.AddSingleton(typeof(OperationStorer));
            services.AddSingleton(typeof(OrderStorer));
        }
    }
}
