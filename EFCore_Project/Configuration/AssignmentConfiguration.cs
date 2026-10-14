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
        builder.Property(x => x.Id)
            .IsRequired();
        builder.Property(x => x.Feedback)
            .HasColumnType("varchar")
            .HasMaxLength(255);
        
    }
}