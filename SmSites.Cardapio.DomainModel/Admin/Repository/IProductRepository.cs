using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Product;
using SmSites.Cardapio.Application.DomainModel.Admin.Enums;

namespace SmSites.Cardapio.Application.DomainModel.Admin.Repository
{
    public interface IProductRepository
    {
        public Task AddAsync(Product product);
        public Task<Product> GetByIdAsync(Guid id);
        public Task<IList<Product>> GetAllAsync();
        public Task<IList<Product>> GetAllByCategoryAsync(CategoryType category);
        public Task GetAllByCategoryAsync(Product product);
    }
}
