//////////////////////////////////////
// generated IStoreService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IStoreService
    {
        Task<string> AddStore(Store entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Store> entities, string Message)> FindStore(Expression<Func<Store, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Store> entities, string Message)> GetAllStore(CancellationToken cancellationToken = default);
        Task<(Store? entity, string Message)> GetStoreById(string StoreId, CancellationToken cancellationToken = default);
        Task<string> RemoveStore(string StoreId, CancellationToken cancellationToken = default);
        Task<string> UpdateStore(Store entity, CancellationToken cancellationToken = default);
    }
}
