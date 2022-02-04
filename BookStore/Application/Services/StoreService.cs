/////////////////////////////////////
// generated StoreService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class StoreService : IStoreService
    {
        private readonly IRepositoryManager _repositoryManager;

        public StoreService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<Store> entities, string Message)> FindStore(Expression<Func<Store, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.StoreRepository.Find(expression);
            return (items, "Store records retrieved");
        }

        public async Task<(IEnumerable<Store> entities, string Message)> GetAllStore(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.StoreRepository.GetAll();
            return (items, "Store records retrieved");
        }

        public async Task<(Store? entity, string Message)> GetStoreById(string StoreId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.StoreRepository.GetById(StoreId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Store", StoreId.ToString());
            }
            return (item, "Store record retrieved");
        }

        public async Task<string> AddStore(Store entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.StoreRepository.GetById(entity.StoreId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("Store", entity.StoreId.ToString());
                }
                else
                {
                    await _repositoryManager.StoreRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Store record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemoveStore(string StoreId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.StoreRepository.GetById(StoreId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Store", StoreId.ToString());
            }
            else
            {
                _repositoryManager.StoreRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "Store record deleted";
            }
        }

        public async Task<string> UpdateStore(Store entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.StoreRepository.GetById(entity.StoreId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("Store", entity.StoreId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.StoreRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Store record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
