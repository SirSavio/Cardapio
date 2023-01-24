using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Product;
using SmSites.Cardapio.Application.DomainModel.Admin.Repository;

namespace SMSites.Cardapio.Application.UseCase.Admin.Products.AddProduct
{
    public class AddProductInteractor
    {
        private readonly IProductRepository _repository;

        public AddProductInteractor(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddProductPortOut> ExecuteAsync(AddProductPortIn portIn)
        {
            var product = new Product(Guid.NewGuid(), portIn.Name, portIn.Description, 
                portIn.Image, portIn.Price, portIn.Category);
            await _repository.AddAsync(product);

            var portOut = new AddProductPortOut(product.Id);
            return portOut;
        }
    }
}
