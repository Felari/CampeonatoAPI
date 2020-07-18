using Campeonato.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Domain.Models
{
    public class VisualizaCampeonatoSydyViewModel
    {

        public int Id { get; set; }
        public string Campeao { get; set; }
        public string Vice { get; set; }
        public string Terceiro { get; set; }
        public virtual List<VisualizaPartidaViewModel> Partidas { get; set; }

    }
}
