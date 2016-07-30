using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace NetCoreShop.Data.Infrastructure
{
    public abstract class RepositoryBase<T> where T:class
    {
        protected readonly NetCoreShopContext Context;
        protected readonly DbSet<T> DbSet;

        protected RepositoryBase(IDbContextFactory<NetCoreShopContext> contextFactory)
        {
            Context = contextFactory.Create(null);
            DbSet = Context.Set<T>();
        }

        public void Add(T entity)
        {
            DbSet.Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return DbSet.AsEnumerable();
        }
    }
}
