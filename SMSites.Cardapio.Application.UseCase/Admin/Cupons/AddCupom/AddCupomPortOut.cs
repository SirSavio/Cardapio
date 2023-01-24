namespace SMSites.Cardapio.Application.UseCase.Admin.Cupons.AddCupom
{
    public class AddCupomPortOut
    {
        public AddCupomPortOut(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
