using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class CertificateConfiguration:IEntityTypeConfiguration<Certificate>
{
    public void Configure(EntityTypeBuilder<Certificate> builder)
    {
        throw new NotImplementedException();
        builder.ToTable("Certificate");
        builder.Property(x => x.CertificateId)
            .ValueGeneratedNever().IsRequired();
        
    }
}