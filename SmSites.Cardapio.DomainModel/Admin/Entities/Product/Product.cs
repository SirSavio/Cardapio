using SmSites.Cardapio.Application.DomainModel.Admin.Enums;
using SmSites.Cardapio.Application.DomainModel.Core;

namespace SmSites.Cardapio.Application.DomainModel.Admin.Entities.Product
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Image { get; private set; }
        public decimal Price { get; private set; }
        public CategoryType Category { get; private set; }
        public bool Active { get; private set; }


        public Product(Guid id, string name, string description, 
            string image, decimal price, CategoryType category) : base(id)
        {
            Name = name;
            Description = description;
            Image = image;
            Price = price;
            Category = category;
            Active = true;
        }

        public void Deactivate()
        {
            Active = false;
        }

        public void Activate()
        {
            Active = true;
        }

        public void Update(string name, string description, 
            string image, decimal price, CategoryType category) 
        {
            Name = name;
            Description = description;  
            Image = image;
            Price = price;
            Category = category;
        }
    }
}
