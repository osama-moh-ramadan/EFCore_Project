using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class CourseConfiguration:IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.ToTable("Courses");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
        builder.Property(x => x.Hours)
            .HasColumnType("Decimal").IsRequired();
        builder.HasOne(x=>x.Instructor)
            .WithMany(x=>x.Courses)
            .HasForeignKey(x=>x.InstructorId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(x => x.Category)
            .WithMany()
            .HasForeignKey(y=>y.CategoryId);
        builder.HasOne(c => c.PreRequiredCourse)
            .WithMany()
            .HasForeignKey(c => c.PreRequiredCourseId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}