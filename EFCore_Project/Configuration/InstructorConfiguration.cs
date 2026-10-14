using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class InstructorConfiguration:IEntityTypeConfiguration<Instructor>
{
    public void Configure(EntityTypeBuilder<Instructor> builder)
    {
        throw new NotImplementedException();
        builder.Property(x => x.Id)
            .ValueGeneratedNever().IsRequired();
        
    }
}