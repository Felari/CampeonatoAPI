using Campeonato.Domain.Interfaces;
using Campeonato.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Infra.CrossCutting.IoC
{
    public static class SqlServerRepositoryDependency
    {

        public static void AddSqlServerRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryTime, TimeRepository>();
            services.AddScoped<IRepositoryCampeonatoSydy, CampeonatoSydyRepository>();


        }

    }
}
