using Campeonato.Domain.Entidades;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Campeonato.Domain.Entidade
{
    public class TimeEntity : BaseEntity<int, TimeEntity>
    {
        [Required]
        [MinLength(3)]
        public string Nome { get; set; }
        public virtual ICollection<ParticipanteEntity> Participantes { get; set; }
        public virtual ICollection<PartidaEntity> PartidasCasa { get; set; }
        public virtual ICollection<PartidaEntity> PartidasVisitante { get; set; }

    }
}
