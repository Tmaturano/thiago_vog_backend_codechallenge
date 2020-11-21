using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Interfaces;

namespace VogCodeChallenge.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
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

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<IList<TEntity>> ListAll()
        {
            return await _repository.ListAll();
        }
    }
}
