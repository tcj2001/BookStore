/////////////////////////////////
// generated ServiceManager.cs //
/////////////////////////////////
using Application.Interfaces;
using Domain.Interfaces;

namespace Application.Services
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<IStoreService> _lazyStoreService;
        private readonly Lazy<ISaleService> _lazySaleService;
        private readonly Lazy<IBookService> _lazyBookService;
        private readonly Lazy<IUserService> _lazyUserService;
        private readonly Lazy<IRefreshTokenService> _lazyRefreshTokenService;
        private readonly Lazy<IJobService> _lazyJobService;
        private readonly Lazy<IRoleService> _lazyRoleService;
        private readonly Lazy<IBookAuthorService> _lazyBookAuthorService;
        private readonly Lazy<IAuthorService> _lazyAuthorService;
        private readonly Lazy<IPublisherService> _lazyPublisherService;
        public ServiceManager(IRepositoryManager repositoryManager)
        {
            _lazyStoreService = new Lazy<IStoreService>(() => new StoreService(repositoryManager));
            _lazySaleService = new Lazy<ISaleService>(() => new SaleService(repositoryManager));
            _lazyBookService = new Lazy<IBookService>(() => new BookService(repositoryManager));
            _lazyUserService = new Lazy<IUserService>(() => new UserService(repositoryManager));
            _lazyRefreshTokenService = new Lazy<IRefreshTokenService>(() => new RefreshTokenService(repositoryManager));
            _lazyJobService = new Lazy<IJobService>(() => new JobService(repositoryManager));
            _lazyRoleService = new Lazy<IRoleService>(() => new RoleService(repositoryManager));
            _lazyBookAuthorService = new Lazy<IBookAuthorService>(() => new BookAuthorService(repositoryManager));
            _lazyAuthorService = new Lazy<IAuthorService>(() => new AuthorService(repositoryManager));
            _lazyPublisherService = new Lazy<IPublisherService>(() => new PublisherService(repositoryManager));
        }
        public IStoreService StoreService => _lazyStoreService.Value;
        public ISaleService SaleService => _lazySaleService.Value;
        public IBookService BookService => _lazyBookService.Value;
        public IUserService UserService => _lazyUserService.Value;
        public IRefreshTokenService RefreshTokenService => _lazyRefreshTokenService.Value;
        public IJobService JobService => _lazyJobService.Value;
        public IRoleService RoleService => _lazyRoleService.Value;
        public IBookAuthorService BookAuthorService => _lazyBookAuthorService.Value;
        public IAuthorService AuthorService => _lazyAuthorService.Value;
        public IPublisherService PublisherService => _lazyPublisherService.Value;
    }
}
