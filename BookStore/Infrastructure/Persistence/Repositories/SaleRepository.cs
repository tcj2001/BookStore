////////////////////////////////////////
// generated SaleRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class SaleRepository : GenericRepository<Sale>, ISaleRepository
    {
        public SaleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<Sale>> GetSaleByName(string name)
        //{
        //    return await _context.Set<Sale>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
