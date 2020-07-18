using Campeonato.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Campeonato.Domain.Entidade
{
    public class CampeonatoSydyEntity : BaseEntity<int, CampeonatoSydyEntity>
    {
        [Required]
        [MinLength(3)]
        public string Nome { get; set; }
        public virtual ICollection<ParticipanteEntity> Participantes { get; set; }
        public virtual ICollection<PartidaEntity> Partidas { get; set; }
    }
}
