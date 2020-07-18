using Campeonato.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Domain.Interfaces
{
    public interface IServiceTime
    {

        VisualizaTimeViewModel Insert(AdicionaTimeViewModel timeViewModel);

        VisualizaTimeViewModel Update(int id, AtualizaTimeViewModel AtualizatimeViewModel);

        void Delete(int id);

        VisualizaTimeViewModel RecoverById(int id);

        IEnumerable<VisualizaTimeViewModel> RecoverAll();

    }
}
