using Campeonato.Domain.Entidade;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Infra.Data.Mapping
{
    public class PartidaMapping : IEntityTypeConfiguration<PartidaEntity>
    {

        public void Configure(EntityTypeBuilder<PartidaEntity> builder)
        {
            var randomizer = new Random();


            builder.ToTable("Partida");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.TimeVisitante)
               .WithMany(x => x.PartidasVisitante)
               .OnDelete(DeleteBehavior.Restrict)
               .HasForeignKey(x => x.TimeVisitanteId)
               .IsRequired(false);

            builder.HasOne(x => x.TimeCasa)
                .WithMany(x => x.PartidasCasa)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(x => x.TimeCasaId)                
                .IsRequired(false);


            builder.HasData(
                 new PartidaEntity
                 {
                     Id = 1,
                     CampeonatoId = 1,
                     TimeCasaId = 1,
                     TimeVisitanteId = 2,
                     GolTimeCasa = randomizer.Next(0, 10),
                     GolTimeVisitante = randomizer.Next(0, 10)
                 },
                new PartidaEntity
                {
                    Id = 2,
                    CampeonatoId = 1,
                    TimeCasaId = 1,
                    TimeVisitanteId = 3,
                    GolTimeCasa = randomizer.Next(0, 10),
                    GolTimeVisitante = randomizer.Next(0, 10)
                },
                new PartidaEntity
                {
                    Id = 3,
                    CampeonatoId = 1,
                    TimeCasaId = 1,
                    TimeVisitanteId = 4,
                    GolTimeCasa = randomizer.Next(0, 10),
                    GolTimeVisitante = randomizer.Next(0, 10)
                },
                new PartidaEntity
                {
                    Id = 4,
                    CampeonatoId = 1,
                    TimeCasaId = 2,
                    TimeVisitanteId = 3,
                    GolTimeCasa = randomizer.Next(0, 10),
                    GolTimeVisitante = randomizer.Next(0, 10)
                },
                new PartidaEntity
                {
                    Id = 5,
                    CampeonatoId = 1,
                    TimeCasaId = 2,
                    TimeVisitanteId = 4,
                    GolTimeCasa = randomizer.Next(0, 10),
                    GolTimeVisitante = randomizer.Next(0, 10)
                },
                new PartidaEntity
                {
                    Id = 6,
                    CampeonatoId = 1,
                    TimeCasaId = 3,
                    TimeVisitanteId = 4,
                    GolTimeCasa = randomizer.Next(0, 10),
                    GolTimeVisitante = randomizer.Next(0, 10)
                }
            );
        }

    }
}
