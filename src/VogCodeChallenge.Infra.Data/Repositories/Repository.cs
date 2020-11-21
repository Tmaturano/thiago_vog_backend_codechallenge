using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Interfaces;
using VogCodeChallenge.Infra.Data.Context;

namespace VogCodeChallenge.Infra.Data.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly VogContext Context;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(VogContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll() => await DbSet.AsNoTracking().ToListAsync();

        public virtual async Task<IList<TEntity>> ListAll() => await DbSet.AsNoTracking().ToListAsync();
    }
}
