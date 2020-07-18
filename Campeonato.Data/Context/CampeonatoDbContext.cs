using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Campeonato.Domain.Entidade;
using Campeonato.Infra.Data.Mapping;

namespace Campeonato.Infra.Data.Context
{
    public class CampeonatoDbContext : DbContext
    {

        public CampeonatoDbContext(DbContextOptions<CampeonatoDbContext> options) : base(options)
        {
        }
        public DbSet<TimeEntity> Time { get; set; }
        public DbSet<CampeonatoSydyEntity> CampeonatoSydy { get; set; }
        public DbSet<PartidaEntity> Partida { get; set; }
        public DbSet<ParticipanteEntity> Participante { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TimeEntity>(new TimeMapping().Configure);
            modelBuilder.Entity<CampeonatoSydyEntity>(new CampeonatoSydyMapping().Configure);
            modelBuilder.Entity<ParticipanteEntity>(new ParticipanteMapping().Configure);
            modelBuilder.Entity<PartidaEntity>(new PartidaMapping().Configure);
        }

    }
}
