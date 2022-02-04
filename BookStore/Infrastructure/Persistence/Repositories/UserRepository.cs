////////////////////////////////////////
// generated UserRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<User>> GetUserByName(string name)
        //{
        //    return await _context.Set<User>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
