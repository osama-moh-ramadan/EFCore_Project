using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class QuizConfiguration:IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.ToTable("Quizes");
        builder.Property(x => x.Id)
           .IsRequired();
        builder.Property(x => x.Title)
            .HasColumnType("VARCHAR")
            .HasMaxLength(50);
        builder.Property(x => x.Duration)
            .HasColumnType("DECIMAL");
        builder.HasOne(x => x.Course)
            .WithMany(x=>x.Quizzes)
            .HasForeignKey(x=>x.CourseId);
        
    }
}