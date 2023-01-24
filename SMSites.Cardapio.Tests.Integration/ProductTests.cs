using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Product;
using SmSites.Cardapio.Application.DomainModel.Admin.Enums;
using Xunit;

namespace SMSites.Cardapio.Tests.Integration
{
    public class ProductTests
    {
        [Fact]
        public void Product_New_Success()
        {
            var productId = Guid.NewGuid();
            var name = "Product 01";
            var desc = "Description";
            var image = "Image";
            decimal price = 10;
            var category = CategoryType.Hamburguer;

            var product = new Product(productId, name, desc, image, price, category);

            Assert.Equal(productId, product.Id);
            Assert.Equal(name, product.Name);
            Assert.Equal(desc, product.Description);
            Assert.Equal(image, product.Image);
            Assert.Equal(price, product.Price);
            Assert.Equal(category, product.Category);
        }
    }
}