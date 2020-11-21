using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VogCodeChallenge.Domain.Interfaces
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<IList<TEntity>> ListAll();
    }
}
