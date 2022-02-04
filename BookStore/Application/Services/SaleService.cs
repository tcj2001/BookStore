/////////////////////////////////////
// generated SaleService.cs //
/////////////////////////////////////
using Application.Interfaces;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Interfaces;
using System.Linq.Expressions;

namespace Application.Services
{
    public class SaleService : ISaleService
    {
        private readonly IRepositoryManager _repositoryManager;

        public SaleService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        public async Task<(IEnumerable<Sale> entities, string Message)> FindSale(Expression<Func<Sale, bool>> expression, CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.SaleRepository.Find(expression);
            return (items, "Sale records retrieved");
        }

        public async Task<(IEnumerable<Sale> entities, string Message)> GetAllSale(CancellationToken cancellationToken = default)
        {
            var items = await _repositoryManager.SaleRepository.GetAll();
            return (items, "Sale records retrieved");
        }

        public async Task<(Sale? entity, string Message)> GetSaleById(int SaleId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.SaleRepository.GetById(SaleId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Sale", SaleId.ToString());
            }
            return (item, "Sale record retrieved");
        }

        public async Task<string> AddSale(Sale entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.SaleRepository.GetById(entity.SaleId);
                if (item != null)
                {
                    throw new EntityKeyFoundException("Sale", entity.SaleId.ToString());
                }
                else
                {
                    await _repositoryManager.SaleRepository.Add(entity);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Sale record added";
                }
            }
            throw new Exception("Add Error");
        }

        public async Task<string> RemoveSale(int SaleId, CancellationToken cancellationToken = default)
        {
            var item = await _repositoryManager.SaleRepository.GetById(SaleId);
            if (item == null)
            {
                throw new EntityKeyNotFoundException("Sale", SaleId.ToString());
            }
            else
            {
                _repositoryManager.SaleRepository.Remove(item);
                await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                return "Sale record deleted";
            }
        }

        public async Task<string> UpdateSale(Sale entity, CancellationToken cancellationToken = default)
        {
            if (entity != null)
            {
                var item = await _repositoryManager.SaleRepository.GetById(entity.SaleId);
                if (item == null)
                {
                    throw new EntityKeyNotFoundException("Sale", entity.SaleId.ToString());
                }
                else
                {
                    //only place that need change if structure changes
                    //item.Name = entity.Name;
                    //item.Description = entity.Description;

                    _repositoryManager.SaleRepository.Update(item);
                    await _repositoryManager.UnitOfWork.CompleteAsync(cancellationToken);
                    return "Sale record updated";
                }
            }
            throw new Exception("Update Error");
        }
    }
}
