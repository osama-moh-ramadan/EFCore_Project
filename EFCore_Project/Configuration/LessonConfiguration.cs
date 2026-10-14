using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class LessonConfiguration:IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder.ToTable("Lessons");
        builder.Property(x => x.Id)
           .IsRequired();
        builder.Property(x => x.Name)
            .HasColumnType("VARCHAR").HasMaxLength(50);
        
        
    }
}