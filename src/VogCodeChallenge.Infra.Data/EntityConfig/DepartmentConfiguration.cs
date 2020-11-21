using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VogCodeChallenge.Domain.Entities;

namespace VogCodeChallenge.Infra.Data.EntityConfig
{
    public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("Departments");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(d => d.Address).HasColumnType("VARCHAR(150)").IsRequired();

            builder.HasMany(d => d.Employees)
                .WithOne(e => e.Department)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
