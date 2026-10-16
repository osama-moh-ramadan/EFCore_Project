using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class StudentSubmissionConfiguration : IEntityTypeConfiguration<StudentSubmission>
{
    public void Configure(EntityTypeBuilder<StudentSubmission> builder)
    {
        builder.ToTable("StudentSubmissions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.DoneAt).IsRequired();
        builder.Property(x => x.Content).IsRequired();
        builder.Property(x => x.Grade).HasColumnType("decimal(18,2)");
        builder.Property(x => x.Feedback);

        builder.HasOne(s => s.Student)
            .WithMany()
            .HasForeignKey(s => s.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(s => s.Assignment)
            .WithMany(a => a.StudentSubmissions)
            .HasForeignKey(s => s.AssignmentId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
