//////////////////////////////////////
// generated IPublisherService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IPublisherService
    {
        Task<string> AddPublisher(Publisher entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Publisher> entities, string Message)> FindPublisher(Expression<Func<Publisher, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Publisher> entities, string Message)> GetAllPublisher(CancellationToken cancellationToken = default);
        Task<(Publisher? entity, string Message)> GetPublisherById(int PubId, CancellationToken cancellationToken = default);
        Task<string> RemovePublisher(int PubId, CancellationToken cancellationToken = default);
        Task<string> UpdatePublisher(Publisher entity, CancellationToken cancellationToken = default);
    }
}
