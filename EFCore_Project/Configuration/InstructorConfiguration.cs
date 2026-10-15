using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class InstructorConfiguration:IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
   
        builder.ToTable("Instructors");
        builder.HasKey(x=>x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
    }
}