using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class UserConfiguration:IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(x => x.Id)
            .IsRequired();
        builder.Property(x => x.Name)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50).IsRequired();
        builder.Property(x => x.Email)
            .HasColumnType("varchar")
            .HasMaxLength(200);
        builder.Property(x => x.HashPassword)
            .HasColumnType("VARCHAR(200)").IsRequired();
        builder.HasIndex(x=>x.Email).IsUnique();
        
    }
}