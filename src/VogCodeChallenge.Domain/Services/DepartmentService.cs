using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Domain.Interfaces;

namespace VogCodeChallenge.Domain.Services
{
    public class DepartmentService : ServiceBase<Department>, IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository): base(departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<IEnumerable<Department>> GetEmployeesByDepartmentIdAsync(Guid departmentId)
        {
            return await _departmentRepository.GetEmployeesByDepartmentIdAsync(departmentId);
        }
    }
}
