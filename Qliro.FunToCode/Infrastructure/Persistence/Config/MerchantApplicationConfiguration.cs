using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Qliro.FunToCode.Domain.MerchantApplications;

namespace Qliro.FunToCode.Infrastructure.Persistence.Config;

public class MerchantApplicationConfiguration : IEntityTypeConfiguration<MerchantApplication>
{
  public void Configure(EntityTypeBuilder<MerchantApplication> builder)
  {
    builder
      .HasKey(p => p.Id);
    
    builder
      .Property(p => p.Id);
    
    builder
      .Property(p => p.Name)
      .IsRequired();

    builder
      .Property(p => p.CreatedAt);

    builder.Property(x => x.Status)
      .HasConversion(
        x => x.Value,
        x => MerchantApplicationStatus.FromValue(x));
  }
}