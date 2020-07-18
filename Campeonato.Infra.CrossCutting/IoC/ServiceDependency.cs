using Campeonato.Domain.Interfaces;
using Campeonato.Service.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Infra.CrossCutting.IoC
{
    public static class ServiceDependency
    {

        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceTime, TimeService>();

        }

    }
}
