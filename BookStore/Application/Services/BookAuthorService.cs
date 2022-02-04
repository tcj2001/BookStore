/////////////////////////////////////
// generated BookAuthorService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class BookAuthorService : IBookAuthorService
    {
        private readonly IRepositoryManager _repositoryManager;

        public BookAuthorService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<BookAuthor> entities, string Message)> FindBookAuthor(Expression<Func<BookAuthor, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.BookAuthorRepository.Find(expression);
            return (items, "BookAuthor records retrieved");
        }

        public async Task<(IEnumerable<BookAuthor> entities, string Message)> GetAllBookAuthor(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.BookAuthorRepository.GetAll();
            return (items, "BookAuthor records retrieved");
        }

        public async Task<(BookAuthor? entity, string Message)> GetBookAuthorById(int AuthorId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.BookAuthorRepository.GetById(AuthorId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("BookAuthor", AuthorId.ToString());
            }
            return (item, "BookAuthor record retrieved");
        }

        public async Task<string> AddBookAuthor(BookAuthor entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.BookAuthorRepository.GetById(entity.AuthorId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("BookAuthor", entity.AuthorId.ToString());
                }
                else
                {
                    await _repositoryManager.BookAuthorRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "BookAuthor record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemoveBookAuthor(int AuthorId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.BookAuthorRepository.GetById(AuthorId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("BookAuthor", AuthorId.ToString());
            }
            else
            {
                _repositoryManager.BookAuthorRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "BookAuthor record deleted";
            }
        }

        public async Task<string> UpdateBookAuthor(BookAuthor entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.BookAuthorRepository.GetById(entity.AuthorId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("BookAuthor", entity.AuthorId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.BookAuthorRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "BookAuthor record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
