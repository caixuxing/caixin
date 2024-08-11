﻿
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CaiXin.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices
        (this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("Database");

        // Add services to the container.

        services.AddDbContext<ApplicationDbContext>((sp,options) =>
        {
           // options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());

           options.UseSqlServer(connectionString);
        });


        return services;
    }
}

