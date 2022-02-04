//////////////////////////////////////
// generated IRefreshTokenService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IRefreshTokenService
    {
        Task<string> AddRefreshToken(RefreshToken entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<RefreshToken> entities, string Message)> FindRefreshToken(Expression<Func<RefreshToken, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<RefreshToken> entities, string Message)> GetAllRefreshToken(CancellationToken cancellationToken = default);
        Task<(RefreshToken? entity, string Message)> GetRefreshTokenById(int TokenId, CancellationToken cancellationToken = default);
        Task<string> RemoveRefreshToken(int TokenId, CancellationToken cancellationToken = default);
        Task<string> UpdateRefreshToken(RefreshToken entity, CancellationToken cancellationToken = default);
    }
}
