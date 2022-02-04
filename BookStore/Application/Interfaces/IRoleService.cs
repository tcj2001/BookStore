//////////////////////////////////////
// generated IRoleService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IRoleService
    {
        Task<string> AddRole(Role entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Role> entities, string Message)> FindRole(Expression<Func<Role, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Role> entities, string Message)> GetAllRole(CancellationToken cancellationToken = default);
        Task<(Role? entity, string Message)> GetRoleById(short RoleId, CancellationToken cancellationToken = default);
        Task<string> RemoveRole(short RoleId, CancellationToken cancellationToken = default);
        Task<string> UpdateRole(Role entity, CancellationToken cancellationToken = default);
    }
}
