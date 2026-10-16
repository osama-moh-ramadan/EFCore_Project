using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class CategoryConfiguration:IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Name)
            .HasColumnType("nvarchar")
            .HasMaxLength(50)
            .IsRequired();
        builder.ToTable("Categories");
    }
}