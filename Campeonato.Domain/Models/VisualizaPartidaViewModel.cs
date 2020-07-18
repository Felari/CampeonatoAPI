using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Domain.Models
{
    public class VisualizaPartidaViewModel
    {
        public string TimeCasa { get; set; }
        public string TimeVisitante { get; set; }
        public int GolsTimeCasa { get; set; }
        public int GolsTimeVisitante { get; set; }
    }
}
