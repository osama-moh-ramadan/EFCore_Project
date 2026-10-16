using EFCore_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Project.Configuration;

public class PaymentConfiguration:IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payments");
        builder.Property(x => x.Id)
            .IsRequired();
        builder.Property(x => x.IsDone)
            .IsRequired();
    }
}