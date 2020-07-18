using System;
using System.Collections.Generic;
using System.Text;
using Campeonato.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Campeonato.Infra.CrossCutting.IoC
{
    public static class SqlServerDependency
    {
        public static void AddSqlServerDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CampeonatoDbContext>(options =>
            {
                options.UseSqlServer($"Server=(localdb)\\mssqllocaldb;Database=TimesDB;Trusted_Connection=True");
            });
        }

    }
}
