namespace SMSites.Cardapio.Application.UseCase.Admin.Cupons.AddCupom
{
    public class AddCupomPortIn
    {
        public AddCupomPortIn(string code, int quantity, DateTime expiration, decimal discount, decimal percentage)
        {
            Code = code;
            Quantity = quantity;
            Expiration = expiration;
            Discount = discount;
            Percentage = percentage;
        }

        public string Code { get; set; }
        public int Quantity { get; set; }
        public DateTime Expiration { get; set; }
        public decimal Discount { get; set; }
        public decimal Percentage { get; set; }
    }
}
