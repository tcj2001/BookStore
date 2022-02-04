/////////////////////////////////////
// generated PublisherService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IRepositoryManager _repositoryManager;

        public PublisherService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<Publisher> entities, string Message)> FindPublisher(Expression<Func<Publisher, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.PublisherRepository.Find(expression);
            return (items, "Publisher records retrieved");
        }

        public async Task<(IEnumerable<Publisher> entities, string Message)> GetAllPublisher(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.PublisherRepository.GetAll();
            return (items, "Publisher records retrieved");
        }

        public async Task<(Publisher? entity, string Message)> GetPublisherById(int PubId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.PublisherRepository.GetById(PubId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Publisher", PubId.ToString());
            }
            return (item, "Publisher record retrieved");
        }

        public async Task<string> AddPublisher(Publisher entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.PublisherRepository.GetById(entity.PubId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("Publisher", entity.PubId.ToString());
                }
                else
                {
                    await _repositoryManager.PublisherRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Publisher record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemovePublisher(int PubId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.PublisherRepository.GetById(PubId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Publisher", PubId.ToString());
            }
            else
            {
                _repositoryManager.PublisherRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "Publisher record deleted";
            }
        }

        public async Task<string> UpdatePublisher(Publisher entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.PublisherRepository.GetById(entity.PubId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("Publisher", entity.PubId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.PublisherRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Publisher record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
