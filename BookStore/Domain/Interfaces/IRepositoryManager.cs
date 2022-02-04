/////////////////////////////////////
// generated IRepositoryManager.cs //
/////////////////////////////////////
namespace Domain.Interfaces
{
    public interface IRepositoryManager
    {
        IStoreRepository StoreRepository { get; }
        ISaleRepository SaleRepository { get; }
        IBookRepository BookRepository { get; }
        IUserRepository UserRepository { get; }
        IRefreshTokenRepository RefreshTokenRepository { get; }
        IJobRepository JobRepository { get; }
        IRoleRepository RoleRepository { get; }
        IBookAuthorRepository BookAuthorRepository { get; }
        IAuthorRepository AuthorRepository { get; }
        IPublisherRepository PublisherRepository { get; }
        IUnitOfWork UnitOfWork { get; }
    }
}
