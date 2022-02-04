////////////////////////////////////////
// generated AuthorRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class AuthorRepository : GenericRepository<Author>, IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<Author>> GetAuthorByName(string name)
        //{
        //    return await _context.Set<Author>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
