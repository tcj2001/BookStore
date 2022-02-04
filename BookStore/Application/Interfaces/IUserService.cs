//////////////////////////////////////
// generated IUserService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IUserService
    {
        Task<string> AddUser(User entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<User> entities, string Message)> FindUser(Expression<Func<User, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<User> entities, string Message)> GetAllUser(CancellationToken cancellationToken = default);
        Task<(User? entity, string Message)> GetUserById(int UserId, CancellationToken cancellationToken = default);
        Task<string> RemoveUser(int UserId, CancellationToken cancellationToken = default);
        Task<string> UpdateUser(User entity, CancellationToken cancellationToken = default);
    }
}
