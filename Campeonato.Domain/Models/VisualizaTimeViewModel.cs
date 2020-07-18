using Campeonato.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Campeonato.Domain.Models
{
    public class VisualizaTimeViewModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        [AllowNull]
        public virtual ICollection<Participantes> Participantes { get; set; }
        [AllowNull]
        public virtual ICollection<PartidaEntity> PartidasCasa { get; set; }
        [AllowNull]
        public virtual ICollection<PartidaEntity> PartidasVisitante { get; set; }
    }
}
