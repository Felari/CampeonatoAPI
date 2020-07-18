using Campeonato.Domain.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Campeonato.Infra.Data.Mapping
{
    public class TimeMapping : IEntityTypeConfiguration<TimeEntity>
    {
        public void Configure(EntityTypeBuilder<TimeEntity> builder)
        {
            builder.ToTable("Time");

            builder.HasKey(c => c.Id);

            builder.HasIndex(x => x.Nome)
                .IsUnique();

            builder.HasData(
                new TimeEntity
                {
                    Id = 1,
                    Nome = "Sydy Novo",
                },
                new TimeEntity
                {
                    Id = 2,
                    Nome = "Concorrente",
                },
                new TimeEntity
                {
                    Id = 3,
                    Nome = "Visitante",
                },
                new TimeEntity
                {
                    Id = 4,
                    Nome = "Time Flopado",
                },
                new TimeEntity
                {
                    Id = 5,
                    Nome = "Time Hypado",
                }
            );
        }
    }
}
