using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Domain.Interfaces;

namespace VogCodeChallenge.Domain.Services
{
    public class DepartmentService : ServiceBase<Department>, IDepartmentService
    {
        public DepartmentService(IDepartmentRepository departmentRepository): base(departmentRepository)
        {
        }
    }
}
