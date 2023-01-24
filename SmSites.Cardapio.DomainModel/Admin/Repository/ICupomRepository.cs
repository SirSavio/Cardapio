using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Cupom;
using SmSites.Cardapio.Application.DomainModel.Admin.Enums;

namespace SmSites.Cardapio.Application.DomainModel.Admin.Repository
{
    public interface ICupomRepository
    {
        public Task AddAsync(Cupom product);
        public Task<Cupom> GetByCodeAsync(string code);
        public Task<IList<Cupom>> GetAllAsync();
    }
}
