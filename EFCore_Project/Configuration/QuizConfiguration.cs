using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class QuizConfiguration:IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        throw new NotImplementedException();
        builder.ToTable("Quizes");
        builder.Property(x => x.Id)
            .ValueGeneratedNever().IsRequired();
        builder.Property(x => x.Title)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
        builder.Property(x => x.Duration)
            .HasColumnType("DECIMAL");
        
    }
}