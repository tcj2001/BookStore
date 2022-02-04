//////////////////////////////////////
// generated IJobService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IJobService
    {
        Task<string> AddJob(Job entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Job> entities, string Message)> FindJob(Expression<Func<Job, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Job> entities, string Message)> GetAllJob(CancellationToken cancellationToken = default);
        Task<(Job? entity, string Message)> GetJobById(short JobId, CancellationToken cancellationToken = default);
        Task<string> RemoveJob(short JobId, CancellationToken cancellationToken = default);
        Task<string> UpdateJob(Job entity, CancellationToken cancellationToken = default);
    }
}
