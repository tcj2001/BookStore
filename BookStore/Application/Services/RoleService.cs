/////////////////////////////////////
// generated RoleService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class RoleService : IRoleService
    {
        private readonly IRepositoryManager _repositoryManager;

        public RoleService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<Role> entities, string Message)> FindRole(Expression<Func<Role, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.RoleRepository.Find(expression);
            return (items, "Role records retrieved");
        }

        public async Task<(IEnumerable<Role> entities, string Message)> GetAllRole(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.RoleRepository.GetAll();
            return (items, "Role records retrieved");
        }

        public async Task<(Role? entity, string Message)> GetRoleById(short RoleId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.RoleRepository.GetById(RoleId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Role", RoleId.ToString());
            }
            return (item, "Role record retrieved");
        }

        public async Task<string> AddRole(Role entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.RoleRepository.GetById(entity.RoleId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("Role", entity.RoleId.ToString());
                }
                else
                {
                    await _repositoryManager.RoleRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Role record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemoveRole(short RoleId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.RoleRepository.GetById(RoleId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Role", RoleId.ToString());
            }
            else
            {
                _repositoryManager.RoleRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "Role record deleted";
            }
        }

        public async Task<string> UpdateRole(Role entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.RoleRepository.GetById(entity.RoleId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("Role", entity.RoleId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.RoleRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Role record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
