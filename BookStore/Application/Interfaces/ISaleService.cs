//////////////////////////////////////
// generated ISaleService.cs //
//////////////////////////////////////
using Domain.Entities;
using System.Linq.Expressions;

namespace Application.Interfaces
{
    public interface ISaleService
    {
        Task<string> AddSale(Sale entity, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Sale> entities, string Message)> FindSale(Expression<Func<Sale, bool>> expression, CancellationToken cancellationToken = default);
        Task<(IEnumerable<Sale> entities, string Message)> GetAllSale(CancellationToken cancellationToken = default);
        Task<(Sale? entity, string Message)> GetSaleById(int SaleId, CancellationToken cancellationToken = default);
        Task<string> RemoveSale(int SaleId, CancellationToken cancellationToken = default);
        Task<string> UpdateSale(Sale entity, CancellationToken cancellationToken = default);
    }
}
