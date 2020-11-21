using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Interfaces;

namespace VogCodeChallenge.Domain.Services
{
    public abstract class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;

        public ServiceBase(IRepository<TEntity> repository)
        {
            _repository = repository;
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll() => await _repository.GetAll();

        public virtual async Task<IList<TEntity>> ListAll() => await _repository.ListAll();
    }
}
