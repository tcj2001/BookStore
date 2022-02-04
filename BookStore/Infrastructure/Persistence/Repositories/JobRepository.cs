////////////////////////////////////////
// generated JobRepository.cs //
////////////////////////////////////////
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class JobRepository : GenericRepository<Job>, IJobRepository
    {
        public JobRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        //public async Task<IEnumerable<Job>> GetJobByName(string name)
        //{
        //    return await _context.Set<Job>().Where(x => x.Name == name).ToListAsync();
        //}
    }
}
