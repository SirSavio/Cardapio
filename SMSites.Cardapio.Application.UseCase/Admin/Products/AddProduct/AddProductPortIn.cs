using SmSites.Cardapio.Application.DomainModel.Admin.Enums;

namespace SMSites.Cardapio.Application.UseCase.Admin.Products.AddProduct
{
    public class AddProductPortIn
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public CategoryType Category { get; set; }
        public bool Active { get; set; }

        public AddProductPortIn(string name, string description, string image, decimal price, CategoryType category)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            Category = category;
            Active = true;
        }

        public AddProductPortIn() { }
    }
}
