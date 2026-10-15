using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class LessonProgressConfig:IEntityTypeConfiguration<LessonProgress>
{
    public void Configure(EntityTypeBuilder<LessonProgress> builder)
    {
     builder.ToTable("LessonProgress");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.HasOne(x => x.Student)
            .WithMany(x=>x.LessonProgresses)
            .HasForeignKey(f=>f.StudentId);
        builder.HasOne(x=>x.Lesson)
            .WithMany(x=>x.LessonProgress)
            .HasForeignKey(f=>f.LessonId);
        
    }
}