namespace SMSites.Cardapio.Application.UseCase.Admin.Products.AddProduct
{
    public class AddProductPortOut
    {
        public Guid Id { get; set; }

        public AddProductPortOut(Guid id)
        {
            Id = id;
        }
    }
}
