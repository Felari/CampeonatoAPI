
using Campeonato.Domain.Entidade;
using Campeonato.Domain.Interfaces;
using Campeonato.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace Campeonato.Infra.Data.Repository
{
    public class CampeonatoSydyRepository : BaseRepository<CampeonatoSydyEntity, int>, IRepositoryCampeonatoSydy
    {

        public CampeonatoSydyRepository(CampeonatoDbContext dbContext) : base(dbContext)
        {
        }

        //public void Remove(int id) =>
        //   base.Delete(id);

        //public void Save(CampeonatoSydyEntity obj)
        //{
        //    if (obj.Id == 0)
        //        base.Insert(obj);
        //    else
        //        base.Update(obj);
        //}

        //public CampeonatoSydyEntity GetById(int id) =>
        //    base.Select(id);

        public IList<CampeonatoSydyEntity> GetAll()
        {
            var campeonatos = _DbContext.CampeonatoSydy.Include(t => t.Partidas)
                .ThenInclude(x => x.TimeVisitante)
                .Include(x => x.Partidas)
                .ThenInclude(x => x.TimeCasa)
                .Include(x => x.Participantes).ToList();
            return campeonatos;
        }

    }
}
