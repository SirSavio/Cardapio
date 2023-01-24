using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Cupom;
using SmSites.Cardapio.Application.DomainModel.Admin.Entities.cupom;
using SMSites.Cardapio.PortOut.DataAccess.FluentApi.Constants;

namespace SMSites.Cardapio.PortOut.DataAccess.FluentApi.Admin.Cupons
{
    public class CupomFA : IEntityTypeConfiguration<Cupom>
    {
        public void Configure(EntityTypeBuilder<Cupom> builder)
        {
            builder.HasKey(cupom => cupom.Id);
            builder.Property(cupom => cupom.Code).HasMaxLength(DataAccessConstants.MaxLength).IsRequired();
            builder.Property(cupom => cupom.Quantity).HasMaxLength(DataAccessConstants.MaxLength).IsRequired();
            builder.Property(cupom => cupom.Expiration).IsRequired();
            builder.Property(cupom => cupom.Discount).IsRequired();
            builder.Property(cupom => cupom.Percentage).IsRequired();
            builder.Property(cupom => cupom.Active).HasDefaultValue(true).IsRequired();
        }
    }
}
