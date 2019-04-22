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
using CursoAspNet.Data.Identity;
using Microsoft.AspNetCore.Identity;
using CursoAspNet.Domain.Account;

namespace CursoAspNet.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            services.AddIdentity<ApplicationUser, IdentityRole>(config =>
            {
                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 4;
                config.Password.RequireLowercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>()
              .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options => options.AccessDeniedPath = "/Account/Login");
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IAuthentication), typeof(Authentication));
            services.AddScoped(typeof(ItemStorer));
            services.AddScoped(typeof(OperationStorer));
            services.AddScoped(typeof(OrderStorer));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
