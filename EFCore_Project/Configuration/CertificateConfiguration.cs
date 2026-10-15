using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class CertificateConfiguration:IEntityTypeConfiguration<Certificate>
{
    public void Configure(EntityTypeBuilder<Certificate> builder)
    {
        builder.ToTable("Certificates");
        builder.HasKey(x => x.CertificateId);
        builder.HasOne(x => x.Student)
            .WithMany(x => x.Certificates)
            .HasForeignKey(x => x.StudentId);
        builder.HasOne(x => x.Course)
            .WithMany(x=>x.Certificates);
        
    }
}