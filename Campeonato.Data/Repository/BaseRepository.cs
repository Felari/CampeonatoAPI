using Campeonato.Domain.Entidades;
using Campeonato.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace Campeonato.Infra.Data.Repository
{
    public class BaseRepository<TEntity, TKeyType> where TEntity : BaseEntity<TKeyType, TEntity>
    {
        protected readonly CampeonatoDbContext _DbContext;
        
        public BaseRepository(CampeonatoDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        protected virtual void Insert(TEntity obj)
        {
            _DbContext.Set<TEntity>().Add(obj);
            _DbContext.SaveChanges();
        }

        protected virtual void Update(TEntity obj)
        {
            _DbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _DbContext.SaveChanges();
        }

        protected virtual void Delete(int id)
        {
            _DbContext.Set<TEntity>().Remove(Select(id));
            _DbContext.SaveChanges();
        }

        protected virtual IList<TEntity> Select() =>
            _DbContext.Set<TEntity>().ToList();

        protected virtual TEntity Select(int id) =>
            _DbContext.Set<TEntity>().Find(id);
    }

}

