using Microsoft.EntityFrameworkCore;
using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Product;
using SmSites.Cardapio.Application.DomainModel.Admin.Enums;
using SMSites.Cardapio.PortOut.DataAccess.Context;

namespace SMSites.Cardapio.PortOut.DataAccess.Repositories.Admin
{
    internal class ProductRepository
    {
        private readonly Database _context;

        public ProductRepository(Database context)
        {
            _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.AddAsync(product);
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetByIdAsync(Guid id)
        {
            var product = await _context.Products.FirstAsync(product => product.Id == id);
            return product;
        }

        public async Task<IList<Product>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        public async Task<IList<Product>> GetAllByCategoryAsync(CategoryType category)
        {
            var products = await _context.Products.Where(product => product.Category == category).ToListAsync();
            return products;
        }

        public async Task GetAllByCategoryAsync(Product product)
        {
            _context.Products.Update(product);
            await _context.SaveChangesAsync();
        }
    }
}
