using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class LessonProgressConfig:IEntityTypeConfiguration<LessonProgress>
{
    public void Configure(EntityTypeBuilder<LessonProgress> builder)
    {
        throw new NotImplementedException();
        builder.Property(x => x.Id)
            .ValueGeneratedNever().IsRequired();
        builder.ToTable("LessonProgress");
        
    }
}