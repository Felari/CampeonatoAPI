using Campeonato.Domain.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Infra.Data.Mapping
{
    public class CampeonatoSydyMapping : IEntityTypeConfiguration<CampeonatoSydyEntity>
    {
        public void Configure(EntityTypeBuilder<CampeonatoSydyEntity> builder)
        {

            builder.ToTable("CampeonatoSydy");

            builder.HasKey(c => c.Id);
            builder.HasData(
                new CampeonatoSydyEntity
                {
                    Id = 1,
                    Nome = "Sydy Championship"
                }
            );
        }
    }
}
