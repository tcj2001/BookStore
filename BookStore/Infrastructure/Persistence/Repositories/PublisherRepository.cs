////////////////////////////////////////
// generated PublisherRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class PublisherRepository : GenericRepository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<Publisher>> GetPublisherByName(string name)
        //{
        //    return await _context.Set<Publisher>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
