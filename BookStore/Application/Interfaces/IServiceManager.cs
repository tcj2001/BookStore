//////////////////////////////////
// generated IServiceManager.cs //
//////////////////////////////////
namespace Application.Interfaces
{
    public interface IServiceManager
    {
        IStoreService StoreService { get; }
        ISaleService SaleService { get; }
        IBookService BookService { get; }
        IUserService UserService { get; }
        IRefreshTokenService RefreshTokenService { get; }
        IJobService JobService { get; }
        IRoleService RoleService { get; }
        IBookAuthorService BookAuthorService { get; }
        IAuthorService AuthorService { get; }
        IPublisherService PublisherService { get; }
    }
}
