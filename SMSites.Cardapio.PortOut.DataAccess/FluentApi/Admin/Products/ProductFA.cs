using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Product;
using SMSites.Cardapio.PortOut.DataAccess.FluentApi.Constants;

namespace SMSites.Cardapio.PortOut.DataAccess.FluentApi.Admin.Products
{
    public class ProductFA : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Name).HasMaxLength(DataAccessConstants.MaxLength).IsRequired();
            builder.Property(product => product.Description).HasMaxLength(DataAccessConstants.MaxLength).IsRequired();
            builder.Property(product => product.Price).IsRequired();
            builder.Property(product => product.Image).IsRequired();
            builder.Property(product => product.Category).IsRequired();
            builder.Property(product => product.Active).HasDefaultValue(true).IsRequired();
        }
    }
}
