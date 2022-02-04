/////////////////////////////////////
// generated RefreshTokenService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class RefreshTokenService : IRefreshTokenService
    {
        private readonly IRepositoryManager _repositoryManager;

        public RefreshTokenService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<RefreshToken> entities, string Message)> FindRefreshToken(Expression<Func<RefreshToken, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.RefreshTokenRepository.Find(expression);
            return (items, "RefreshToken records retrieved");
        }

        public async Task<(IEnumerable<RefreshToken> entities, string Message)> GetAllRefreshToken(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.RefreshTokenRepository.GetAll();
            return (items, "RefreshToken records retrieved");
        }

        public async Task<(RefreshToken? entity, string Message)> GetRefreshTokenById(int TokenId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.RefreshTokenRepository.GetById(TokenId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("RefreshToken", TokenId.ToString());
            }
            return (item, "RefreshToken record retrieved");
        }

        public async Task<string> AddRefreshToken(RefreshToken entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.RefreshTokenRepository.GetById(entity.TokenId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("RefreshToken", entity.TokenId.ToString());
                }
                else
                {
                    await _repositoryManager.RefreshTokenRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "RefreshToken record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemoveRefreshToken(int TokenId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.RefreshTokenRepository.GetById(TokenId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("RefreshToken", TokenId.ToString());
            }
            else
            {
                _repositoryManager.RefreshTokenRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "RefreshToken record deleted";
            }
        }

        public async Task<string> UpdateRefreshToken(RefreshToken entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.RefreshTokenRepository.GetById(entity.TokenId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("RefreshToken", entity.TokenId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.RefreshTokenRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "RefreshToken record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
