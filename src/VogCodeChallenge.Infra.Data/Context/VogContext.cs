using Microsoft.EntityFrameworkCore;
using VogCodeChallenge.Domain.Entities;
using VogCodeChallenge.Infra.Data.EntityConfig;

namespace VogCodeChallenge.Infra.Data.Context
{
    public class VogContext : DbContext
    {
        public VogContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
