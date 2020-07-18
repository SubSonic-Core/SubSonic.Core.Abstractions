using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SubSonic
{
    public interface IIncludableQueryable<out TEntity, out Property>
        : IIncludableQueryable, IQueryable<TEntity>, IEnumerable<TEntity>
    { 
        
    }

    public interface IIncludableQueryable
        : IQueryable, IEnumerable
    {
        Type PropertyType { get; }
    }
}
