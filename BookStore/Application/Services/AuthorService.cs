/////////////////////////////////////
// generated AuthorService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepositoryManager _repositoryManager;

        public AuthorService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<Author> entities, string Message)> FindAuthor(Expression<Func<Author, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.AuthorRepository.Find(expression);
            return (items, "Author records retrieved");
        }

        public async Task<(IEnumerable<Author> entities, string Message)> GetAllAuthor(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.AuthorRepository.GetAll();
            return (items, "Author records retrieved");
        }

        public async Task<(Author? entity, string Message)> GetAuthorById(int AuthorId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.AuthorRepository.GetById(AuthorId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Author", AuthorId.ToString());
            }
            return (item, "Author record retrieved");
        }

        public async Task<string> AddAuthor(Author entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.AuthorRepository.GetById(entity.AuthorId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("Author", entity.AuthorId.ToString());
                }
                else
                {
                    await _repositoryManager.AuthorRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Author record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemoveAuthor(int AuthorId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.AuthorRepository.GetById(AuthorId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Author", AuthorId.ToString());
            }
            else
            {
                _repositoryManager.AuthorRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "Author record deleted";
            }
        }

        public async Task<string> UpdateAuthor(Author entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.AuthorRepository.GetById(entity.AuthorId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("Author", entity.AuthorId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.AuthorRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Author record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
