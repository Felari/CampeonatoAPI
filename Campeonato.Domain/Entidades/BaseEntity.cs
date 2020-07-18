using System;
using System.Collections.Generic;
using System.Text;

namespace Campeonato.Domain.Entidades
{
    public abstract class BaseEntity<TKeyType, TEntity>
    {
        protected BaseEntity(TKeyType id = default)
        {
            Id = id;
        }

        public virtual TKeyType Id { get; set; }
    }
}
