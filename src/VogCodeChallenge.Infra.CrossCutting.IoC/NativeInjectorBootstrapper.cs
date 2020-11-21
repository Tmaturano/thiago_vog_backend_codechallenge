using Microsoft.Extensions.DependencyInjection;
using VogCodeChallenge.Domain.Interfaces;
using VogCodeChallenge.Domain.Services;
using VogCodeChallenge.Infra.Data.Context;
using VogCodeChallenge.Infra.Data.Repositories;

namespace VogCodeChallenge.Infra.CrossCutting.IoC
{
    public class NativeInjectorBootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Services
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            // Repositories
            services.AddScoped<VogContext>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
