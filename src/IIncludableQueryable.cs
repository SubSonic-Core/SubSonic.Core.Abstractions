using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SubSonic
{
    public interface IIncludableQueryable<out TEntity, out Property>
        : IQueryable<TEntity>, IEnumerable<TEntity>, IQueryable, IEnumerable
    { 
        Type PropertyType { get; }
    }
}
