using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Domain.Models
{
    public class TimeViewModel
    {

        public List<VisualizaTimeViewModel> Times { get; set; }
        public int pgnAtual { get; set; }
        public int qtdPaginas { get; set; }
    }
}
