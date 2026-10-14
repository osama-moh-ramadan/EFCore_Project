using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Identity.Client.NativeInterop;
using Module = EFCore_Project.Entities.Module;

namespace EFCore_Project.Configuration;

public class ModuleConfiguration:IEntityTypeConfiguration<Entities.Module>
{
    public void Configure(EntityTypeBuilder<Module> builder)
    {
        throw new NotImplementedException();
        builder.ToTable("Modules");
        builder.Property(x => x.Id)
            .ValueGeneratedNever().IsRequired();
        builder.Property(x => x.Name)
            .HasColumnType("VARCHAR").HasMaxLength(50);
        
    }
}