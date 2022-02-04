////////////////////////////////////////
// generated BookAuthorRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class BookAuthorRepository : GenericRepository<BookAuthor>, IBookAuthorRepository
    {
        public BookAuthorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<BookAuthor>> GetBookAuthorByName(string name)
        //{
        //    return await _context.Set<BookAuthor>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
