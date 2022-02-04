//////////////////////////////////////
// generated IBookService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IBookService
    {
        Task<string> AddBook(Book entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Book> entities, string Message)> FindBook(Expression<Func<Book, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Book> entities, string Message)> GetAllBook(CancellationToken cancellationToken = default);
        Task<(Book? entity, string Message)> GetBookById(int BookId, CancellationToken cancellationToken = default);
        Task<string> RemoveBook(int BookId, CancellationToken cancellationToken = default);
        Task<string> UpdateBook(Book entity, CancellationToken cancellationToken = default);
    }
}
