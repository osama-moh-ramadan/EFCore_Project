using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class AssignmentConfiguration:IEntityTypeConfiguration<Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder.ToTable("Assignments");
        builder.HasKey(x => x.Id);
        builder.HasOne(x=>x.Course)
            .WithMany(x=>x.Assignments).HasForeignKey(f=>f.CourseId);
        builder.HasOne(x=>x.Instructor)
            .WithMany(x=>x.Assignments).HasForeignKey(f=>f.InstructorId);
       
        
    }
}