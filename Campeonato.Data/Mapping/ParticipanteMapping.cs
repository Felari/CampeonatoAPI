using Campeonato.Domain.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Infra.Data.Mapping
{
    public class ParticipanteMapping : IEntityTypeConfiguration<ParticipanteEntity>
    {
        public void Configure(EntityTypeBuilder<ParticipanteEntity> builder)
        {
            builder.ToTable("Participante");
            builder.HasKey(c => c.Id);

            builder.HasData(
                new ParticipanteEntity
                {
                    Id = 1,
                    CampeonatoId = 1,
                    TimeId = 1
                },
                new ParticipanteEntity
                {
                    Id = 2,
                    CampeonatoId = 1,
                    TimeId = 2
                },
                new ParticipanteEntity
                {
                    Id = 3,
                    CampeonatoId = 1,
                    TimeId = 3
                },
                new ParticipanteEntity
                {
                    Id = 4,
                    CampeonatoId = 1,
                    TimeId = 4
                }
            );
        }

    }
}
