using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Cupom;
using SmSites.Cardapio.Application.DomainModel.Admin.Repository;

namespace SMSites.Cardapio.Application.UseCase.Admin.Cupons.AddCupom
{
    public class AddCupomInteractor
    {
        private readonly ICupomRepository _repository;

        public AddCupomInteractor(ICupomRepository repository)
        {
            _repository = repository;
        }

        public async Task<AddCupomPortOut> ExecuteAsync(AddCupomPortIn portIn)
        {
            var cupom = new Cupom(Guid.NewGuid(), portIn.Code, portIn.Quantity,
                portIn.Expiration, portIn.Discount, portIn.Percentage);
            await _repository.AddAsync(cupom);

            var portOut = new AddCupomPortOut(cupom.Id);
            return portOut;
        }
    }
}
