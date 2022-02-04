//////////////////////////////////////
// generated IBookAuthorService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IBookAuthorService
    {
        Task<string> AddBookAuthor(BookAuthor entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<BookAuthor> entities, string Message)> FindBookAuthor(Expression<Func<BookAuthor, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<BookAuthor> entities, string Message)> GetAllBookAuthor(CancellationToken cancellationToken = default);
        Task<(BookAuthor? entity, string Message)> GetBookAuthorById(int AuthorId, CancellationToken cancellationToken = default);
        Task<string> RemoveBookAuthor(int AuthorId, CancellationToken cancellationToken = default);
        Task<string> UpdateBookAuthor(BookAuthor entity, CancellationToken cancellationToken = default);
    }
}
