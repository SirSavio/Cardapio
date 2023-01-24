using Microsoft.EntityFrameworkCore;
using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Cupom;
using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Product;
using SMSites.Cardapio.PortOut.DataAccess.FluentApi.Admin.Products;

namespace SMSites.Cardapio.PortOut.DataAccess.Context
{
    internal class Database : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Cupom> Cupons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductFA());
            modelBuilder.ApplyConfiguration(new CupomFA());
            base.OnModelCreating(modelBuilder);
        }
    }
}
