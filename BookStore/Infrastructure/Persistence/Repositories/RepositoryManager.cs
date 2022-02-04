////////////////////////////////////
// generated RepositoryManager.cs //
////////////////////////////////////
using Domain.Interfaces;
using Infrastructure.Persistence.Context;

namespace Infrastructure.Persistence.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Lazy<IStoreRepository> _lazyStoreRepository;
        private readonly Lazy<ISaleRepository> _lazySaleRepository;
        private readonly Lazy<IBookRepository> _lazyBookRepository;
        private readonly Lazy<IUserRepository> _lazyUserRepository;
        private readonly Lazy<IRefreshTokenRepository> _lazyRefreshTokenRepository;
        private readonly Lazy<IJobRepository> _lazyJobRepository;
        private readonly Lazy<IRoleRepository> _lazyRoleRepository;
        private readonly Lazy<IBookAuthorRepository> _lazyBookAuthorRepository;
        private readonly Lazy<IAuthorRepository> _lazyAuthorRepository;
        private readonly Lazy<IPublisherRepository> _lazyPublisherRepository;
        private readonly Lazy<IUnitOfWork> _lazyUnitOfWork;

        public RepositoryManager(ApplicationDbContext context)
        {
            _lazyStoreRepository = new Lazy<IStoreRepository>(() => new StoreRepository(context));
            _lazySaleRepository = new Lazy<ISaleRepository>(() => new SaleRepository(context));
            _lazyBookRepository = new Lazy<IBookRepository>(() => new BookRepository(context));
            _lazyUserRepository = new Lazy<IUserRepository>(() => new UserRepository(context));
            _lazyRefreshTokenRepository = new Lazy<IRefreshTokenRepository>(() => new RefreshTokenRepository(context));
            _lazyJobRepository = new Lazy<IJobRepository>(() => new JobRepository(context));
            _lazyRoleRepository = new Lazy<IRoleRepository>(() => new RoleRepository(context));
            _lazyBookAuthorRepository = new Lazy<IBookAuthorRepository>(() => new BookAuthorRepository(context));
            _lazyAuthorRepository = new Lazy<IAuthorRepository>(() => new AuthorRepository(context));
            _lazyPublisherRepository = new Lazy<IPublisherRepository>(() => new PublisherRepository(context));
            _lazyUnitOfWork = new Lazy<IUnitOfWork>(() => new UnitOfWork(context));
        }
        public IStoreRepository StoreRepository => _lazyStoreRepository.Value;
        public ISaleRepository SaleRepository => _lazySaleRepository.Value;
        public IBookRepository BookRepository => _lazyBookRepository.Value;
        public IUserRepository UserRepository => _lazyUserRepository.Value;
        public IRefreshTokenRepository RefreshTokenRepository => _lazyRefreshTokenRepository.Value;
        public IJobRepository JobRepository => _lazyJobRepository.Value;
        public IRoleRepository RoleRepository => _lazyRoleRepository.Value;
        public IBookAuthorRepository BookAuthorRepository => _lazyBookAuthorRepository.Value;
        public IAuthorRepository AuthorRepository => _lazyAuthorRepository.Value;
        public IPublisherRepository PublisherRepository => _lazyPublisherRepository.Value;
        public IUnitOfWork UnitOfWork => _lazyUnitOfWork.Value;
    }
}
