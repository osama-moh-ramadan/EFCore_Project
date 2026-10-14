using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class QuestionConfiguration:IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.Property(x => x.Id)
           .IsRequired();
        builder.Property(x => x.CorrectAnswer)
            .HasColumnType("CHAR");
        builder.Property(x => x.Text)
            .HasColumnType("NVARCHAR")
            .HasMaxLength(250);
        builder.ToTable("Questions");
    }
}