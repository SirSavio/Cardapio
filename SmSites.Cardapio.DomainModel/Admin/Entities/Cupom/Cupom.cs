using SmSites.Cardapio.Application.DomainModel.Core;

namespace SmSites.Cardapio.Application.DomainModel.Admin.Entities.Cupom
{
    public class Cupom : Entity
    {

        public string Code { get; private set; }
        public int Quantity { get; private set; }
        public DateTime Expiration { get; private set; }
        public decimal Discount { get; private set; }
        public decimal Percentage { get; private set; }
        public bool Active { get; private set; }

        public Cupom(Guid id, string code, int quantity, DateTime expiration, decimal discount, decimal percentage) : base(id)
        {
            Code = code;
            Quantity = quantity;
            Expiration = expiration;
            Discount = discount;
            Percentage = percentage;
            Active = true;
        }
    }
}
