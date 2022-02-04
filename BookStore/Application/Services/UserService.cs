/////////////////////////////////////
// generated UserService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class UserService : IUserService
    {
        private readonly IRepositoryManager _repositoryManager;

        public UserService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<User> entities, string Message)> FindUser(Expression<Func<User, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.UserRepository.Find(expression);
            return (items, "User records retrieved");
        }

        public async Task<(IEnumerable<User> entities, string Message)> GetAllUser(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.UserRepository.GetAll();
            return (items, "User records retrieved");
        }

        public async Task<(User? entity, string Message)> GetUserById(int UserId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.UserRepository.GetById(UserId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("User", UserId.ToString());
            }
            return (item, "User record retrieved");
        }

        public async Task<string> AddUser(User entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.UserRepository.GetById(entity.UserId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("User", entity.UserId.ToString());
                }
                else
                {
                    await _repositoryManager.UserRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "User record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemoveUser(int UserId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.UserRepository.GetById(UserId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("User", UserId.ToString());
            }
            else
            {
                _repositoryManager.UserRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "User record deleted";
            }
        }

        public async Task<string> UpdateUser(User entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.UserRepository.GetById(entity.UserId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("User", entity.UserId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.UserRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "User record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
