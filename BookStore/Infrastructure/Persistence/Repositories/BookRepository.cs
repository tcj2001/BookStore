////////////////////////////////////////
// generated BookRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<Book>> GetBookByName(string name)
        //{
        //    return await _context.Set<Book>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
