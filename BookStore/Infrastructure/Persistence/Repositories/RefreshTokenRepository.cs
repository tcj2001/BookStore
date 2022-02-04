////////////////////////////////////////
// generated RefreshTokenRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<RefreshToken>> GetRefreshTokenByName(string name)
        //{
        //    return await _context.Set<RefreshToken>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
