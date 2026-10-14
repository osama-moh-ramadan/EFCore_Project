using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class CourseConfiguration:IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");
        builder.Property(x => x.Id)
           .IsRequired();
        builder.Property(x => x.Name)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
        builder.Property(x => x.Hours)
            .HasColumnType("Decimal").IsRequired();
        
    }
}