using Campeonato.Domain.Entidade;
using Campeonato.Domain.Interfaces;
using Campeonato.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Campeonato.Infra.Data.Repository
{
    public class TimeRepository : BaseRepository<TimeEntity, int>, IRepositoryTime
    {
        public TimeRepository(CampeonatoDbContext dbContext) : base(dbContext)
        {
        }
        public void Remove(int id) =>
            base.Delete(id);

        public void Save(TimeEntity obj)
        {
            if (obj.Id == 0)
                base.Insert(obj);
            else
                base.Update(obj);
        }

        public TimeEntity GetById(int id) =>
            base.Select(id);

        public IList<TimeEntity> GetAll()
        {
            var times = _DbContext.Time.Include(t => t.Participantes)
                .ThenInclude(x => x.Time)
                .ThenInclude(x => x.PartidasCasa)
                .Include(x => x.PartidasVisitante).ToList();
            return times;
        }



    }
}
