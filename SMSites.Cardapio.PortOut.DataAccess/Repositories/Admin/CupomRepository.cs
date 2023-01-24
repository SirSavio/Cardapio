using SmSites.Cardapio.Application.DomainModel.Admin.Entities.Cupom;
using SMSites.Cardapio.PortOut.DataAccess.Context;

namespace SMSites.Cardapio.PortOut.DataAccess.Repositories.Admin
{
    internal class CupomRepository
    {
        private readonly Database _context;

        public CupomRepository(Database context)
        {
            _context = context;
        }

        public async Task AddAsync(Cupom cupom)
        {
            await _context.AddAsync(cupom);
            await _context.SaveChangesAsync();
        }
    }
}
