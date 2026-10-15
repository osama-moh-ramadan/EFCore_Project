using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class EnrollmentConfiguration:IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder.ToTable("Enrollments");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.CourseId).IsRequired();
        builder.Property(x => x.StudentId).IsRequired();
        builder.HasOne(s=>s.Student)
            .WithMany(s=>s.Enrollments)
            .HasForeignKey(s=>s.StudentId);
        builder.HasOne(c => c.Course)
            .WithMany(c=>c.Enrollments)
            .HasForeignKey(c=>c.CourseId);
        builder.HasIndex(e=>new { e.StudentId, e.CourseId }).IsUnique();
    }
}