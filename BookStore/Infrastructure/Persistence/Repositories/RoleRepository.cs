////////////////////////////////////////
// generated RoleRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class RoleRepository : GenericRepository<Role>, IRoleRepository
    {
        public RoleRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<Role>> GetRoleByName(string name)
        //{
        //    return await _context.Set<Role>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
