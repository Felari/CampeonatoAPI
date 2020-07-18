using Campeonato.Domain.Entidades;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Campeonato.Domain.Entidade
{
    public class ParticipanteEntity : BaseEntity<int, ParticipanteEntity>
    {
        [ForeignKey("Time")]
        [Required]
        public int TimeId { get; set; }
        public virtual TimeEntity Time { get; set; }
        [ForeignKey("Campeonato")]
        [Required]
        public int CampeonatoId { get; set; }
        public virtual CampeonatoSydyEntity Campeonato { get; set; }
        public int Pontuacao { get; set; } = 0;

    }
}
