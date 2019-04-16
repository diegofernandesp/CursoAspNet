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
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(ItemStorer));
            services.AddScoped(typeof(OperationStorer));
            services.AddScoped(typeof(OrderStorer));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
