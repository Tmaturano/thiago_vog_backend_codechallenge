using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Domain.Interfaces;
using VogCodeChallenge.Infra.Data.Context;

namespace VogCodeChallenge.Infra.Data.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(VogContext context) : base(context)
        {
        }
    }
}
