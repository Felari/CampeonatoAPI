using Campeonato.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Domain.Interfaces
{
    public interface IRepositoryTime
    {

        void Save(TimeEntity obj);

        void Remove(int id);

        TimeEntity GetById(int id);

        IList<TimeEntity> GetAll();

    }
}
