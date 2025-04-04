﻿using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Pacagroup.Trade.Application.UseCases
{
    public static class DependenciInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}
