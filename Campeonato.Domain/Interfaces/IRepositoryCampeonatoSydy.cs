using Campeonato.Domain.Entidade;
using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Domain.Interfaces
{
    public interface IRepositoryCampeonatoSydy
    {

        //void Save(CampeonatoSydyEntity obj);

        //void Remove(int id);

        //CampeonatoSydyEntity GetById(int id);

        IList<CampeonatoSydyEntity> GetAll();

    }
}
