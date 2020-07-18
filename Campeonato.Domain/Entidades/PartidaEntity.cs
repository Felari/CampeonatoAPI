using Campeonato.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Campeonato.Domain.Entidade
{
    public class PartidaEntity : BaseEntity<int, PartidaEntity>
    {
        [ForeignKey("Campeonato")]
        public int CampeonatoId { get; set; }
        [ForeignKey("TimeVisitante")]
        [Required]
        public int TimeVisitanteId { get; set; }
        [ForeignKey("TimeCasa")]
        [Required]
        public int TimeCasaId { get; set; }
        [Required]
        public int GolTimeVisitante { get; set; }
        [Required]
        public int GolTimeCasa { get; set; }
        public virtual TimeEntity TimeVisitante { get; set; }
        public virtual TimeEntity TimeCasa { get; set; }
        public virtual CampeonatoSydyEntity Campeonato { get; set; }
    }
}
