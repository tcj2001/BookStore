////////////////////////////////////////
// generated StoreRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<Store>> GetStoreByName(string name)
        //{
        //    return await _context.Set<Store>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
