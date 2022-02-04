//////////////////////////////////////
// generated IAuthorService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface IAuthorService
    {
        Task<string> AddAuthor(Author entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Author> entities, string Message)> FindAuthor(Expression<Func<Author, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Author> entities, string Message)> GetAllAuthor(CancellationToken cancellationToken = default);
        Task<(Author? entity, string Message)> GetAuthorById(int AuthorId, CancellationToken cancellationToken = default);
        Task<string> RemoveAuthor(int AuthorId, CancellationToken cancellationToken = default);
        Task<string> UpdateAuthor(Author entity, CancellationToken cancellationToken = default);
    }
}
